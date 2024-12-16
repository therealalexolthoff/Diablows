using UnityEngine;

public class PlayerCombat : CombatReciever
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start() {
        SetFactionID(GetComponent<PlayerController>().GetFactionID());
    }
    public override void Die(){
        base.Die();
        GetComponent<PlayerController>().TriggerDeath();
    }
}
