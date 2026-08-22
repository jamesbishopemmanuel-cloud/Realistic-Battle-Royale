using UnityEngine;
using UnityEngine.UI;


public class PlayerHUD : MonoBehaviour
{

    public Slider healthBar;
    public Text ammoText;
    public Text killText;


    public void UpdateHealth(float health)
    {
        healthBar.value = health;
    }


    public void UpdateAmmo(int ammo)
    {
        ammoText.text =
        "Ammo: " + ammo;
    }


    public void UpdateKills(int kills)
    {
        killText.text =
        "Kills: " + kills;
    }

}