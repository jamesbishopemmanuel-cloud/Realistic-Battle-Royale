using UnityEngine;


public class SquadMatchmaking : MonoBehaviour
{

    public int squadSize = 4;


    public void FindSquadMatch()
    {
        Debug.Log(
        "Searching squad match...");
    }


    public void MatchFound()
    {
        Debug.Log(
        "Squad match ready");
    }

}