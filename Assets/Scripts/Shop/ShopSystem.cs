using UnityEngine;


public class ShopSystem : MonoBehaviour
{

    public int coins = 0;


    public bool BuyItem(int price)
    {

        if(coins >= price)
        {
            coins -= price;

            Debug.Log("Item Purchased");

            return true;
        }


        Debug.Log("Not enough coins");

        return false;
    }

}