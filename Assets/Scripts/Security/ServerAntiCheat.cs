using UnityEngine;


public class ServerAntiCheat : MonoBehaviour
{

    public float maxMovementSpeed = 12f;


    public bool CheckMovement(
    float speed)
    {

        if(speed > maxMovementSpeed)
        {
            Debug.Log(
            "Cheat detected");

            return false;
        }


        return true;
    }

}