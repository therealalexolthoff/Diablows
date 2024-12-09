using UnityEngine;

public class FireballCA : CombatActor
{
    [SerializeField] float speed = 25;
    Vector3 shootDirection = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject,5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(shootDirection * speed * Time.fixedDeltaTime);
    }
    public void SetShootDirection(Vector3 newDirection) {
        shootDirection = newDirection;
    }
    protected override void OnTriggerEnter(Collider other){
        if(other.GetComponent<CombatReciever>() && !other.isTrigger)
    {
        if(other.GetComponent<CombatReciever>().GetFactionID() != factionID)
        {
        HitReceiver(other.GetComponent<CombatReciever>());
        Destroy(gameObject);
        }
    }
    }
}
