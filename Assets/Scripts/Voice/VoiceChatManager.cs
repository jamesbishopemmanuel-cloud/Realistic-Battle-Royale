using UnityEngine;


public class VoiceChatManager : MonoBehaviour
{

    public bool microphoneEnabled;


    public void EnableVoice()
    {
        microphoneEnabled = true;

        Debug.Log(
        "Voice chat enabled");
    }


    public void DisableVoice()
    {
        microphoneEnabled = false;
    }

}