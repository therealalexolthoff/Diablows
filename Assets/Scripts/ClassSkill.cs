using UnityEngine;

public class ClassSkill : MonoBehaviour
{

    [SerializeField] protected int skillLevel = 0;
    [SerializeField] protected string name = "";
    [SerializeField] protected string description = "";
    [SerializeField] protected Sprite iconSprite;
    public virtual void LevelUp()
    {

    }
#region Getters
    public int GetSkillLevel() 
    {
        return skillLevel;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public Sprite GetIconSprite()
    {
        return iconSprite;
    }
#endregion
}
