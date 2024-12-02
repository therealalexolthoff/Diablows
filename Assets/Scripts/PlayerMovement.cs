using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    int factionID = 1;
    NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
void Start(){
    agent = GetComponent<NavMeshAgent>();
}
void Update() {
    if(Input.GetMouseButtonDown(0)){
        RunClickMovement();
    }
}


void RunClickMovement() 
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if(Physics.Raycast(ray, out hit)){
        if(hit.point != Vector3.zero){
            if(hit.point != Vector3.zero)
            {
                MoveToLocation(hit.point);
            }
        }
    }
}
public void MoveToLocation(Vector3 location){
    agent.destination = location;
}

}
