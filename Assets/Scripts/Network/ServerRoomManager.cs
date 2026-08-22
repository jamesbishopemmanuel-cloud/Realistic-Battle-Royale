using UnityEngine;
using System.Collections.Generic;


public class ServerRoomManager : MonoBehaviour
{

    public List<string> players =
    new List<string>();

    public int maxPlayers = 50;


    public bool AddPlayer(string id)
    {
        if(players.Count < maxPlayers)
        {
            players.Add(id);

            Debug.Log(
            id + " joined room");

            return true;
        }

        return false;
    }


    public void RemovePlayer(string id)
    {
        players.Remove(id);
    }

}