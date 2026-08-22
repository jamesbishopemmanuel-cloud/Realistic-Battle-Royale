using UnityEngine;
using System.Collections.Generic;


public class LeaderboardSystem : MonoBehaviour
{

    public Dictionary<string,int> scores =
    new Dictionary<string,int>();


    public void AddScore(
    string player,
    int points)
    {

        if(scores.ContainsKey(player))
        {
            scores[player] += points;
        }
        else
        {
            scores.Add(player,points);
        }

    }


    public int GetScore(string player)
    {
        return scores[player];
    }

}