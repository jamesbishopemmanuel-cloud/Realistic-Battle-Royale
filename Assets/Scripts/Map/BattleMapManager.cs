using UnityEngine;


public class BattleMapManager : MonoBehaviour
{

    public string mapName = "Island";


    public int maxPlayers = 50;


    public void LoadMap()
    {
        Debug.Log(
        "Loading map: " + mapName);
    }


    public void StartBattle()
    {
        Debug.Log(
        "Battle Royale started");
    }

}