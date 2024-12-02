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
}
