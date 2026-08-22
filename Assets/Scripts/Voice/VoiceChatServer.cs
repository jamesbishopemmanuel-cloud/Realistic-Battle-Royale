using UnityEngine;


public class VoiceChatServer : MonoBehaviour
{

    public bool voiceEnabled;


    public void StartVoice()
    {
        voiceEnabled = true;

        Debug.Log(
        "Voice chat started");
    }


    public void StopVoice()
    {
        voiceEnabled = false;
    }

}