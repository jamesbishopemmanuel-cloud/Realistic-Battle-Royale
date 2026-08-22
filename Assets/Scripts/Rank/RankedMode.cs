using UnityEngine;

public class RankedMode : MonoBehaviour
{

    public int rankPoints = 0;


    public string GetRank()
    {

        if(rankPoints < 1000)
            return "Bronze";


        if(rankPoints < 2000)
            return "Silver";


        if(rankPoints < 3000)
            return "Gold";


        if(rankPoints < 4000)
            return "Diamond";


        return "Master";
    }


    public void AddPoints(int points)
    {
        rankPoints += points;
    }

}