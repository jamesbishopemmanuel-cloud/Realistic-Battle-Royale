using UnityEngine;


public class CharacterCustomization : MonoBehaviour
{

    public string characterSkin;
    public string outfit;


    public void ChangeSkin(string skin)
    {
        characterSkin = skin;

        Debug.Log(
        "Skin: " + skin);
    }


    public void ChangeOutfit(string newOutfit)
    {
        outfit = newOutfit;

        Debug.Log(
        "Outfit: " + outfit);
    }

}