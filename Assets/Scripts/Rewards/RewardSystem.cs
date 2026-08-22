using UnityEngine;


public class RewardSystem : MonoBehaviour
{

    public int coins;
    public int diamonds;


    public void GiveCoins(int amount)
    {
        coins += amount;

        Debug.Log(
        "Coins received: " + amount);
    }


    public void GiveDiamonds(int amount)
    {
        diamonds += amount;

        Debug.Log(
        "Diamonds received: " + amount);
    }

}