using UnityEngine;


public class SkinSystem : MonoBehaviour
{

    public string currentSkin;


    public void EquipSkin(string skin)
    {
        currentSkin = skin;

        Debug.Log(
        "Skin equipped: " + skin);
    }

}