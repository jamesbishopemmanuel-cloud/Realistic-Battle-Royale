using UnityEngine;

public class MatchmakingSystem : MonoBehaviour
{

    public int requiredPlayers = 50;

    public void SearchMatch()
    {
        Debug.Log("Searching for battle...");
    }


    public void StartBattle()
    {
        Debug.Log("Match Found!");
    }

}