using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class BasicAI : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected bool alive = true;
    protected int factionID = 0;
    protected virtual void Start()
    {
       agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if(alive) RunAI();
    }
    protected virtual void RunAI()
    {

    }
    public void SetFactionID(int newID)
    {
        factionID = newID;
        GetComponent<CombatReciever>().SetFactionID(factionID);
    }
    public virtual void TriggerDeath() 
    {
        if (!alive) return;

        alive = false;
        
        if(GetComponent<EnemyAnimator>() != null)
            GetComponent<EnemyAnimator>().TriggerDeath();
        Collider[] attachedColliders = GetComponents<Collider>();
        foreach(Collider c in attachedColliders)
        {
            c.enabled = false;
        }
        agent.enabled = false;
    }


}
