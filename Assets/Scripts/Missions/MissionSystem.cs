using UnityEngine;


public class MissionSystem : MonoBehaviour
{

    public int kills;
    public int matches;


    public bool CompleteKillMission()
    {
        return kills >= 10;
    }


    public bool CompleteMatchMission()
    {
        return matches >= 5;
    }


    public void AddKill()
    {
        kills++;
    }


    public void AddMatch()
    {
        matches++;
    }

}