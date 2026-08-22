using UnityEngine;


public class RegionServerManager : MonoBehaviour
{

    public string region;


    public void SelectRegion(string selected)
    {
        region = selected;


        Debug.Log(
        "Server region: "
        + region);
    }

}