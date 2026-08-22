using UnityEngine;


public class AntiCheatSystem : MonoBehaviour
{

    public float maxSpeed = 10;


    public void CheckPlayerSpeed(
    float playerSpeed)
    {

        if(playerSpeed > maxSpeed)
        {
            BanPlayer();
        }

    }


    void BanPlayer()
    {
        Debug.Log(
        "Suspicious player detected");
    }

}