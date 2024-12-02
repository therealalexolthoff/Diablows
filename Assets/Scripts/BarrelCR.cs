using UnityEngine;

public class BarrelCR : CombatReciever
{
    public override void Die()
    {
        base.Die();
        Destroy(gameObject);
    }
}
