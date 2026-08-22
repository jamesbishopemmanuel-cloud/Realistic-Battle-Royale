using UnityEngine;


public class CrashReporter : MonoBehaviour
{

    void Start()
    {
        Application.logMessageReceived +=
        HandleError;
    }


    void HandleError(
    string message,
    string stack,
    LogType type)
    {

        if(type == LogType.Error)
        {
            Debug.Log(
            "Crash Report Saved");
        }

    }

}