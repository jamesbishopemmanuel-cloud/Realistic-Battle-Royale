using UnityEngine;

public class PlayerAccount : MonoBehaviour
{
    public string username;
    public int level = 1;
    public int experience = 0;
    public int coins = 1000;


    public void AddExperience(int amount)
    {
        experience += amount;

        if(experience >= level * 1000)
        {
            LevelUp();
        }
    }


    void LevelUp()
    {
        level++;
        experience = 0;

        Debug.Log(
        "Level Up! New Level: " + level);
    }
}