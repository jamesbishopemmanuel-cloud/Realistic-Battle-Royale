using UnityEngine;


public class GameModeManager : MonoBehaviour
{

    public string currentMode;


    public void SetMode(string mode)
    {
        currentMode = mode;


        Debug.Log(
        "Mode: " + mode);
    }

}