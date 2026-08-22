using UnityEngine;
using System.Collections.Generic;

public class MultiplayerManager : MonoBehaviour
{
    public static MultiplayerManager Instance;

    public List<string> connectedPlayers = new List<string>();

    public int maxPlayers = 50;


    void Awake()
    {
        Instance = this;
    }


    public bool JoinGame(string playerName)
    {
        if(connectedPlayers.Count < maxPlayers)
        {
            connectedPlayers.Add(playerName);

            Debug.Log(playerName + " connected");

            return true;
        }

        return false;
    }


    public void LeaveGame(string playerName)
    {
        connectedPlayers.Remove(playerName);
    }
}