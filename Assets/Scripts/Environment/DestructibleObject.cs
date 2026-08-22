using UnityEngine;


public class DestructibleObject : MonoBehaviour
{

    public float health = 100;


    public void Damage(float amount)
    {
        health -= amount;


        if(health <= 0)
        {
            BreakObject();
        }

    }


    void BreakObject()
    {
        Debug.Log(
        "Object destroyed");

        Destroy(gameObject);
    }

}