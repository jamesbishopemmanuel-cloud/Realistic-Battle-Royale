using UnityEngine;


public class AdvancedBattlePass : MonoBehaviour
{

    public int tier = 1;
    public int xp;


    public void AddXP(int amount)
    {
        xp += amount;


        if(xp >= 1000)
        {
            tier++;
            xp = 0;

            Debug.Log(
            "Battle Pass Tier: "
            + tier);
        }
    }

}