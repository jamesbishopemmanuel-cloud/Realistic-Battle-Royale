using UnityEngine;


public class ArmorSystem : MonoBehaviour
{

    public float armor = 100;


    public float ReduceDamage(float damage)
    {
        float blocked =
        damage * 0.5f;


        armor -= blocked;


        if(armor < 0)
        {
            armor = 0;
        }


        return damage - blocked;
    }

}