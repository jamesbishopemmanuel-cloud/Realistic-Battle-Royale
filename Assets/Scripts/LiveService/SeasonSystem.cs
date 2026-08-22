using UnityEngine;

public class SeasonSystem : MonoBehaviour
{

    public int seasonNumber = 1;
    public int daysRemaining = 90;


    public void StartNewSeason()
    {
        seasonNumber++;
        daysRemaining = 90;

        Debug.Log(
        "New Season: " + seasonNumber);
    }


    public int GetSeason()
    {
        return seasonNumber;
    }

}