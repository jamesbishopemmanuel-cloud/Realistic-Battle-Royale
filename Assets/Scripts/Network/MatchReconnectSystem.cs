using UnityEngine;


public class MatchReconnectSystem : MonoBehaviour
{

    public bool disconnected;


    public void Reconnect()
    {
        disconnected = false;

        Debug.Log(
        "Reconnected to match");
    }


    public void Disconnect()
    {
        disconnected = true;
    }

}