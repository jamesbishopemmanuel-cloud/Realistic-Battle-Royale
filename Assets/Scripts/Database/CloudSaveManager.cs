using UnityEngine;


public class CloudSaveManager : MonoBehaviour
{

    public DatabasePlayer player;


    public void SavePlayer()
    {
        Debug.Log(
        "Player data saved");
    }


    public void LoadPlayer()
    {
        Debug.Log(
        "Player data loaded");
    }

}