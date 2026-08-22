using UnityEngine;


public class SecurityManager : MonoBehaviour
{

    public bool secureMode = true;


    public void EnableSecurity()
    {
        secureMode = true;


        Debug.Log(
        "Security Enabled");
    }


    public void DisableSecurity()
    {
        secureMode = false;
    }

}