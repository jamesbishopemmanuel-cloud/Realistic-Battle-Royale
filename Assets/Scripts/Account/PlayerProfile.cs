using UnityEngine;

public class PlayerProfile : MonoBehaviour
{
    public string playerName;
    public string country;
    public int matchesPlayed;
    public int wins;


    public float GetWinRate()
    {
        if(matchesPlayed == 0)
            return 0;

        return (float)wins / matchesPlayed * 100;
    }
}