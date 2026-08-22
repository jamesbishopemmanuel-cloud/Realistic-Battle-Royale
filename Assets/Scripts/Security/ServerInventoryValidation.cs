using UnityEngine;


public class ServerInventoryValidation : MonoBehaviour
{

    public bool ValidateItem(string item)
    {

        if(string.IsNullOrEmpty(item))
        {
            return false;
        }


        Debug.Log(
        "Item verified: " + item);


        return true;
    }

}