using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpPower = 5f;

    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move =
        new Vector3(x,0,z);


        transform.Translate(
        move * speed * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(
            Vector3.up * jumpPower,
            ForceMode.Impulse);
        }
    }
}