using UnityEngine;


public class VehicleDamageSystem : MonoBehaviour
{

    public float health = 1000;


    public void TakeDamage(
    float damage)
    {
        health -= damage;


        if(health <= 0)
        {
            DestroyVehicle();
        }
    }


    void DestroyVehicle()
    {
        Debug.Log(
        "Vehicle destroyed");
    }

}