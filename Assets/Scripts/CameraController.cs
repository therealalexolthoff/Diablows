using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject followTarget;
    Vector3 offsetVector = new Vector3(10,14,-10);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followTarget != null) Follow();
    }


    public void SetFollowTarget(GameObject target)
    {
        followTarget = target;
    }
    void Follow() 
    {
        transform.position = followTarget.transform.position + offsetVector;
        transform.LookAt(followTarget.transform.position);
    }
}
