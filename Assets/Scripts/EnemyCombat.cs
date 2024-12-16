using UnityEngine;

public class EnemyCombat : CombatReciever
{
  public override void Die(){
    base.Die();
    GetComponent<BasicAI>().TriggerDeath();
  }
}
