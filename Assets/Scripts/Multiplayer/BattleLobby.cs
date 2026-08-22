using UnityEngine;
using System.Collections.Generic;


public class BattleLobby : MonoBehaviour
{

    public List<string> players =
    new List<string>();


    public int maxPlayers = 50;


    public void JoinMatch(string username)
    {

        if(players.Count < maxPlayers)
        {
            players.Add(username);

            Debug.Log(
            username + " joined battle");
        }

    }


    public void StartMatch()
    {
        Debug.Log(
        "Battle Started with "
        + players.Count +
        " players");
    }

}