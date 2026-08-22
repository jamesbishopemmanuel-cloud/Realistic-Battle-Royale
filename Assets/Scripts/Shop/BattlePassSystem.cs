using UnityEngine;


public class BattlePassSystem : MonoBehaviour
{

    public int level = 1;


    public void AddXP(int amount)
    {
        level += amount / 100;


        Debug.Log(
        "Battle Pass Level: "
        + level);
    }

}