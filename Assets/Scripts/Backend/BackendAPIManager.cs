using UnityEngine;


public class BackendAPIManager : MonoBehaviour
{

    public string serverURL =
    "https://your-game-server.com";


    public void ConnectServer()
    {
        Debug.Log(
        "Connecting to backend...");
    }


    public void SendPlayerData(string data)
    {
        Debug.Log(
        "Sending: " + data);
    }


    public void ReceiveData()
    {
        Debug.Log(
        "Receiving server data");
    }

}