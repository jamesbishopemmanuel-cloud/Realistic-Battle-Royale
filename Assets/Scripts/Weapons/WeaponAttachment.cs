using UnityEngine;


public class WeaponAttachment : MonoBehaviour
{

    public bool scope;
    public bool silencer;
    public bool extendedMagazine;


    public float accuracy = 1;


    public void AddScope()
    {
        scope = true;
        accuracy += 0.2f;
    }


    public void AddSilencer()
    {
        silencer = true;
    }

}