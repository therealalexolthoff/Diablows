using UnityEngine;

public class PlayerSheet : MonoBehaviour
{
    int level = 1;
    float experience = 0;

    float strength = 15;
    float dexterity = 15;
    float vitality = 15;
    float energy = 15;

    float currentHitPoints = 35;
    float maxHitPoints = 35;
    float currentMana = 35;
    float maxMana = 35;

    #region Levels and Experience
    public int GetLevel()
    {
        return level;
    }
    public float GetExperience() 
    {
        return experience;
    }

    public void AddExperience(float amount)
    {
        experience += amount;
    }
    #endregion

    #region Get Stats
    public float GetStrength() 
    {
        return strength;
    }
    public float GetDexterity() 
    {
        return dexterity;
    }
    public float GetVitality() 
    {
        return vitality;
    }
    public float GetEnergy() 
    {
        return energy;
    } 

    #endregion

    public float GetMaxHP() {
        return maxHitPoints;
    }
    public float GetMaxMana() 
    {
        return maxMana;
    }
}

