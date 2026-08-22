using UnityEngine;


public class AndroidBuildManager : MonoBehaviour
{

    public string version = "1.0.0";


    public void PrepareBuild()
    {
        Debug.Log(
        "Preparing Android Build v"
        + version);
    }


    public void ReleaseBuild()
    {
        Debug.Log(
        "APK Ready For Release");
    }

}