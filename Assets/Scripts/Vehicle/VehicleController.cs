using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed = 20f;

    private bool driving = false;


    void Update()
    {
        if(driving)
        {
            float move =
            Input.GetAxis("Vertical");

            transform.Translate(
            Vector3.forward *
            move *
            speed *
            Time.deltaTime);
        }
    }


    public void EnterVehicle()
    {
        driving = true;
    }


    public void ExitVehicle()
    {
        driving = false;
    }
}