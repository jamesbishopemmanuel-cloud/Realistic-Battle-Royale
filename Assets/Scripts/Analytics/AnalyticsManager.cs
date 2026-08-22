using UnityEngine;


public class AnalyticsManager : MonoBehaviour
{

    public int playersJoined;

    public int matchesPlayed;


    public void PlayerJoined()
    {
        playersJoined++;
    }


    public void MatchCompleted()
    {
        matchesPlayed++;
    }


    public void ShowStats()
    {
        Debug.Log(
        "Players: "
        + playersJoined
        +
        " Matches: "
        + matchesPlayed);
    }

}