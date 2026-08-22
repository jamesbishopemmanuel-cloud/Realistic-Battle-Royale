using UnityEngine;
using System.Collections.Generic;


public class GameServerManager : MonoBehaviour
{

    public int maxPlayers = 100;

    public List<string> connectedPlayers =
    new List<string>();


    public bool ConnectPlayer(string id)
    {

        if(connectedPlayers.Count < maxPlayers)
        {
            connectedPlayers.Add(id);

            Debug.Log(
            "Player connected: " + id);

            return true;
        }


        return false;
    }


    public void DisconnectPlayer(string id)
    {
        connectedPlayers.Remove(id);
    }


    public int PlayerCount()
    {
        return connectedPlayers.Count;
    }

}