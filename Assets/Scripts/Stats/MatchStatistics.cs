using UnityEngine;


public class MatchStatistics : MonoBehaviour
{

    public int kills;
    public int wins;
    public int matches;


    public void AddKill()
    {
        kills++;
    }


    public void AddWin()
    {
        wins++;
    }


    public void NewMatch()
    {
        matches++;
    }

}