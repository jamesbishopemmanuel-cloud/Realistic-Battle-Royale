using UnityEngine;


public class AdvancedCombatAI : MonoBehaviour
{

    public Transform target;

    public float attackDistance = 20f;


    void Update()
    {

        if(target == null)
            return;


        float distance =
        Vector3.Distance(
        transform.position,
        target.position);


        if(distance <= attackDistance)
        {
            Attack();
        }

    }


    void Attack()
    {
        Debug.Log(
        "AI attacking player");
    }

}