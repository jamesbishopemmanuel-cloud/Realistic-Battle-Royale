using UnityEngine;


public class PlayerPresence : MonoBehaviour
{

    public string status =
    "Online";


    public void SetStatus(string newStatus)
    {
        status = newStatus;

        Debug.Log(
        "Status: " + status);
    }

}