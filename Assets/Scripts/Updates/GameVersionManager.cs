using UnityEngine;


public class GameVersionManager : MonoBehaviour
{

    public string currentVersion = "1.0.0";


    public bool CheckVersion(
    string latestVersion)
    {

        if(currentVersion != latestVersion)
        {
            Debug.Log(
            "Update Available");

            return true;
        }


        return false;
    }

}