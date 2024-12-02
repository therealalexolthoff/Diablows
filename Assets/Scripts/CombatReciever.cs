using UnityEngine;

public class CombatReciever : Clickable
{

    [SerializeField] protected float maxHP = 35;
    protected float currentHP;
    protected bool alive;
    protected int factionID = 0;

    protected virtual void Start()
    {
        currentHP = maxHP;
        // protected bool alive;
        // protected int factionID = 0;   
    }
    public virtual void Die() {
        alive = false;
    }

    public void SetFactionID(int newID)
    {
        factionID = newID;
    }

    public int GetFactionID()
    {
        return factionID;
    }
    public virtual void TakeDamage(float amount){
        if(!alive) return;

        currentHP -= amount;
        if (currentHP <=0) Die(); 
    }

    public virtual void Revive()
    {
        
    }

}
