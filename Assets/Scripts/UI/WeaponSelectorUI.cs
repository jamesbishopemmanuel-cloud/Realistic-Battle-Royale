using UnityEngine;


public class WeaponSelectorUI : MonoBehaviour
{

    public string currentWeapon;


    public void SelectWeapon(string weapon)
    {
        currentWeapon = weapon;


        Debug.Log(
        "Equipped: " + weapon);
    }

}