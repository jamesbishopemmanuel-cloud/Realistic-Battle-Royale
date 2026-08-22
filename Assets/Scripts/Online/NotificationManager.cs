using UnityEngine;


public class NotificationManager : MonoBehaviour
{

    public void SendNotification(string message)
    {
        Debug.Log(
        "Notification: " + message);
    }

}