using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public float shrinkSpeed = 2f;
    public float minimumSize = 20f;

    void Update()
    {
        if(transform.localScale.x > minimumSize)
        {
            transform.localScale -= 
            Vector3.one * shrinkSpeed * Time.deltaTime;
        }
    }
}