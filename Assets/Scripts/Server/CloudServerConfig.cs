using UnityEngine;


public class CloudServerConfig : MonoBehaviour
{

    public string serverName =
    "Battle Royale Cloud";


    public int maxConnections = 100;


    public void StartServer()
    {
        Debug.Log(
        serverName +
        " online");
    }

}