using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Awake() 
   {
    if (instance == null) instance = this;
    else Destroy(gameObject);

    DontDestroyOnLoad(gameObject);
   }
}
