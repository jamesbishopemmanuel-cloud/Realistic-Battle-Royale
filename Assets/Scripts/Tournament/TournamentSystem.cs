using UnityEngine;


public class TournamentSystem : MonoBehaviour
{

    public int playersJoined;


    public void JoinTournament()
    {
        playersJoined++;

        Debug.Log(
        "Tournament players: "
        + playersJoined);
    }


    public void StartTournament()
    {
        Debug.Log(
        "Tournament Started");
    }

}