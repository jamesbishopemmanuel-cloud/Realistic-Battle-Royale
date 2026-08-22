using UnityEngine;

public class FirebaseLogin : MonoBehaviour
{

    public string playerID;


    public void LoginWithPhone(string phoneNumber)
    {
        Debug.Log(
        "OTP sent to: " + phoneNumber);
    }


    public void VerifyOTP(string code)
    {
        playerID = "PLAYER_" + code;

        Debug.Log(
        "Login successful: " + playerID);
    }

}