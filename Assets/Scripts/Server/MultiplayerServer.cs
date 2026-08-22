using UnityEngine;
using System.Collections.Generic;


public class MultiplayerServer : MonoBehaviour
{

    public List<string> players =
    new List<string>();


    public void ConnectPlayer(string id)
    {
        players.Add(id);

        Debug.Log(
        id + " connected");
    }


    public void DisconnectPlayer(string id)
    {
        players.Remove(id);
    }


    public int GetPlayerCount()
    {
        return players.Count;
    }

}