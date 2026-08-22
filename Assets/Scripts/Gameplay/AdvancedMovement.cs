using UnityEngine;

public class AdvancedMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float sprintSpeed = 9f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool grounded;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float speed = 
        Input.GetKey(KeyCode.LeftShift) ?
        sprintSpeed :
        walkSpeed;


        float x =
        Input.GetAxis("Horizontal");

        float z =
        Input.GetAxis("Vertical");


        Vector3 move =
        new Vector3(x,0,z) * speed;


        transform.Translate(
        move * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space)
        && grounded)
        {
            rb.AddForce(
            Vector3.up * jumpForce,
            ForceMode.Impulse);
        }

    }


    void OnCollisionStay()
    {
        grounded = true;
    }

}