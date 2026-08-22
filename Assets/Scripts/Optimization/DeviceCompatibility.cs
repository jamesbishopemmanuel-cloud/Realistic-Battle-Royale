using UnityEngine;


public class DeviceCompatibility : MonoBehaviour
{

    public void CheckDevice()
    {

        Debug.Log(
        "Device: "
        + SystemInfo.deviceModel);


        Debug.Log(
        "RAM: "
        + SystemInfo.systemMemorySize
        + " MB");

    }

}