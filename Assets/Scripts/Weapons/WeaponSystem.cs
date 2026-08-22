using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public float damage = 25f;
    public float range = 100f;

    public Camera playerCamera;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = new Ray(playerCamera.transform.position,
                          playerCamera.transform.forward);

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit,range))
        {
            PlayerHealth enemy =
            hit.transform.GetComponent<PlayerHealth>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}