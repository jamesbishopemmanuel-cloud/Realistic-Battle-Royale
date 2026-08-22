using UnityEngine;


public class CloudPlayerData : MonoBehaviour
{

    public string username;
    public int level;
    public int coins;


    public void SaveData()
    {
        Debug.Log(
        "Player data uploaded");
    }


    public void LoadData()
    {
        Debug.Log(
        "Player data downloaded");
    }

}