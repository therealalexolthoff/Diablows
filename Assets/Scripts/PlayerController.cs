using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] EquippableAbility ability1;
    [SerializeField] EquippableAbility ability2;

    int factionID = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera.main.gameObject.AddComponent<CameraController>();
        Camera.main.gameObject.GetComponent<CameraController>().SetFollowTarget(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ability1 != null) UseAbility1();
        if (Input.GetMouseButtonDown(1) && ability2 != null) UseAbility2();

    }
    void UseAbility1()
    {
        ability1.RunAbilityClicked(this);
    }
    void UseAbility2()
    {
        ability2.RunAbilityClicked(this);
    }
    #region Utility
    public PlayerMovement Movement()
    {
        return GetComponent<PlayerMovement>();
    }
    // public PlayerAnimator GetAnimator() 
    // {
    //     return GetComponent<PlayerAnimator>();
    // }
    public PlayerSheet GetCharacterSheet() 
    {
        return GetComponent<PlayerSheet>();
    }
    public int GetFactionID()
    {
        return factionID;
    }
    #endregion


}
