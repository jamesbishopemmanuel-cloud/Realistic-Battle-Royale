using UnityEngine;


public class GameUpdateManager : MonoBehaviour
{

    public string currentVersion = "1.0";


    public void CheckUpdate()
    {
        Debug.Log(
        "Checking latest version...");
    }


    public void DownloadUpdate()
    {
        Debug.Log(
        "Downloading update...");
    }

}