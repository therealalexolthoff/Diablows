using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isOn = false;

    // Update is called once per frame
    void OnTriggerEnter3D(MeshCollider col)
    {
        isOn = true;
    }
}
