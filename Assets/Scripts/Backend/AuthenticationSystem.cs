using UnityEngine;


public class AuthenticationSystem : MonoBehaviour
{

    public string playerToken;


    public void Login(
    string username,
    string password)
    {

        playerToken =
        "TOKEN_" + username;


        Debug.Log(
        "Login successful");

    }


    public void Logout()
    {
        playerToken = "";

        Debug.Log(
        "Logged out");
    }

}