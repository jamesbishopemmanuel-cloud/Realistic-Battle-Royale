using UnityEngine;
using System.Collections.Generic;


public class MatchmakingServer : MonoBehaviour
{

    public List<string> waitingPlayers =
    new List<string>();


    public void AddPlayer(string id)
    {
        waitingPlayers.Add(id);

        Debug.Log(
        id + " searching match");
    }


    public void CreateMatch()
    {
        Debug.Log(
        "Match created");
    }

}