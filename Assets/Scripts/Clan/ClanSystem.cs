using UnityEngine;
using System.Collections.Generic;


public class ClanSystem : MonoBehaviour
{

    public string clanName;

    public List<string> members =
    new List<string>();


    public void AddMember(string player)
    {
        members.Add(player);

        Debug.Log(
        player + " joined " + clanName);
    }


    public void RemoveMember(string player)
    {
        members.Remove(player);
    }

}