using UnityEngine;

public class MobilePlayerController : MonoBehaviour
{
    public float speed = 5f;

    public Joystick joystick;


    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;


        Vector3 move =
        new Vector3(x,0,z);


        transform.Translate(
        move * speed * Time.deltaTime);
    }
}