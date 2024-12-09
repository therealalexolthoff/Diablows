using UnityEngine;

public class EquippableAbility : ClassSkill
{
    [SerializeField] protected GameObject spawnablePrefab;
    [SerializeField] float attackRange = 1.5f;

    protected CombatReciever targetedReceiver;
    protected PlayerController myPlayer;

    public virtual void RunAbilityClicked(PlayerController player)
    {
        myPlayer = player;
        targetedReceiver = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)){
        player.Movement().MoveToLocation(hit.point);
        if (hit.collider.gameObject.GetComponent<Clickable>())
        {
            targetedReceiver = hit.collider.GetComponent<CombatReciever>();
        }
        }
    }

    protected virtual void SpawnEquippedAttack(Vector3 location){
        GameObject newAttack = Instantiate(spawnablePrefab, location, Quaternion.identity);
        newAttack.GetComponent<CombatActor>().SetFactionID(myPlayer.GetFactionID());
    }
    public virtual void CancelAbility()
    {
        targetedReceiver = null;
    }

    protected virtual void Update() 
    {
        if(targetedReceiver != null) RunTargetAttack();
    }
    protected virtual void RunTargetAttack() 
    {
        if(Vector3.Distance(myPlayer.transform.position, targetedReceiver.transform.position) <= attackRange)
        {
            myPlayer.Movement().MoveToLocation(myPlayer.transform.position);

            Vector3 lookPos = new Vector3(targetedReceiver.transform.position.x, myPlayer.transform.position.y, targetedReceiver.transform.position.z);

            myPlayer.transform.LookAt(lookPos);

            SpawnEquippedAttack(myPlayer.transform.position + myPlayer.transform.forward);

            myPlayer.GetAnimator().TriggerAttack();
        
            targetedReceiver = null;
        }
        else 
        {
            // Chase target
            myPlayer.Movement().MoveToLocation(targetedReceiver.transform.position);
        }
    }
}
