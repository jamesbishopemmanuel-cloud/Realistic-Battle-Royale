using UnityEngine;


public class WeaponRecoil : MonoBehaviour
{

    public float recoilAmount = 2f;


    public Camera weaponCamera;


    public void ApplyRecoil()
    {
        weaponCamera.transform.localRotation *=
        Quaternion.Euler(
        -recoilAmount,
        0,
        0);
    }

}