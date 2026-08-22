using UnityEngine;


public class MatchServer : MonoBehaviour
{

    public bool matchRunning;


    public void StartMatch()
    {
        matchRunning = true;

        Debug.Log(
        "Match Server Started");
    }


    public void EndMatch()
    {
        matchRunning = false;

        Debug.Log(
        "Match Finished");
    }

}