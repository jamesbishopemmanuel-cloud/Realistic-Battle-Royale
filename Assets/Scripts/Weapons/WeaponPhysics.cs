using UnityEngine;

public class WeaponPhysics : MonoBehaviour
{

    public float damage = 30;
    public float recoil = 2;
    public float bulletSpeed = 100;


    public void Fire()
    {
        Debug.Log(
        "Bullet fired");

        ApplyRecoil();
    }


    void ApplyRecoil()
    {
        Debug.Log(
        "Recoil applied: "
        + recoil);
    }

}