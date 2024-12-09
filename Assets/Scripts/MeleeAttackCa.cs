using UnityEngine;

public class MeleeAttackCa : CombatActor
{
   [SerializeField] float speed = 25;

   void Start()
   {
    Destroy(gameObject, .1f);
   }
}
