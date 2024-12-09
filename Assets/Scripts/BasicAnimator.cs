using UnityEngine;

public class BasicAnimator : MonoBehaviour
{
    [SerializeField] protected Animator thisAnimator;
    protected Vector3 oldPos = Vector3.zero;
    protected Vector3 deltaPos = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public virtual void SetWalking(bool val)
   {
    thisAnimator.SetBool("walking", val);
   }
   public virtual void TriggerAttack() {
    thisAnimator.SetTrigger("Attack");
   }
    public virtual void TriggerDeath(){
    thisAnimator.SetTrigger("Die");
    }

    public virtual void TriggerRevive(){
    thisAnimator.SetTrigger("Revive");
    }
}
