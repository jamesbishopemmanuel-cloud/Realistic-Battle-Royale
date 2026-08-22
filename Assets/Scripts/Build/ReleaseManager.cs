using UnityEngine;


public class ReleaseManager : MonoBehaviour
{

    public string version =
    "1.0.0";


    public void PrepareRelease()
    {
        Debug.Log(
        "Preparing Release Version "
        + version);
    }


    public void FinalBuild()
    {
        Debug.Log(
        "Final APK Build Ready");
    }

}