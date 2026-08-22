using UnityEngine;


public class LoadingManager : MonoBehaviour
{

    public float progress;


    public void LoadGame()
    {
        progress = 100;


        Debug.Log(
        "Game Loaded");
    }

}