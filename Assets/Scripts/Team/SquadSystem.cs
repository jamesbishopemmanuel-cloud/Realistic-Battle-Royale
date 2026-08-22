using UnityEngine;
using System.Collections.Generic;


public class SquadSystem : MonoBehaviour
{

    public List<string> squadMembers =
    new List<string>();


    public int maxSquadSize = 4;


    public void JoinSquad(string player)
    {

        if(squadMembers.Count < maxSquadSize)
        {
            squadMembers.Add(player);

            Debug.Log(
            player + " joined squad");
        }

    }


    public void LeaveSquad(string player)
    {
        squadMembers.Remove(player);
    }

}