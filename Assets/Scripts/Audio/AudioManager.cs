using UnityEngine;


public class AudioManager : MonoBehaviour
{

    public AudioSource music;


    public void PlayMusic()
    {
        music.Play();
    }


    public void StopMusic()
    {
        music.Stop();
    }

}