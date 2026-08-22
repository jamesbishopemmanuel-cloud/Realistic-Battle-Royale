using UnityEngine;


public class ServerValidation : MonoBehaviour
{

    public float maxAllowedSpeed = 15f;


    public bool CheckMovement(
    float speed)
    {

        if(speed > maxAllowedSpeed)
        {
            Debug.Log(
            "Invalid movement detected");

            return false;
        }


        return true;
    }

}