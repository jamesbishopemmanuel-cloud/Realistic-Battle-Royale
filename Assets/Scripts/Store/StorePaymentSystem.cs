using UnityEngine;


public class StorePaymentSystem : MonoBehaviour
{

    public int diamonds;


    public void BuyDiamonds(int amount)
    {
        diamonds += amount;

        Debug.Log(
        "Diamonds added: " + amount);
    }


    public void PurchaseSkin(string skin)
    {
        Debug.Log(
        "Purchased: " + skin);
    }

}