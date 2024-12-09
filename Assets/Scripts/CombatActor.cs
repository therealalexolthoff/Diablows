using UnityEngine;

public class CombatActor : MonoBehaviour
{
   protected int factionID = 0;
   protected float damage = 1;

   public virtual void InitializeDamage(float amount){
    damage = amount;
   }

   public void SetFactionID(int newID)
   {
    factionID = newID;
   }
   
   protected virtual void HitReceiver(CombatReciever target) {
    target.TakeDamage(damage);
   }

   protected virtual void OnTriggerEnter(Collider other){
    if(other.GetComponent<CombatReciever>() != null && !other.isTrigger)
    {
        if(other.GetComponent<CombatReciever>().GetFactionID() != factionID)
        {
        HitReceiver(other.GetComponent<CombatReciever>());
        }
    }
}
}