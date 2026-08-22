using UnityEngine;

public class ParachuteDrop : MonoBehaviour
{
    public float fallSpeed = 15f;
    public float glideSpeed = 5f;
    public bool parachuteOpened = false;

    void Update()
    {
        if(!parachuteOpened)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                OpenParachute();
            }
        }
        else
        {
            transform.Translate(Vector3.down * glideSpeed * Time.deltaTime);
        }
    }

    void OpenParachute()
    {
        parachuteOpened = true;
        Debug.Log("Parachute Activated");
    }
}