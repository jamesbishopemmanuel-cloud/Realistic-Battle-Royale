using UnityEngine;

public class NetworkPlayerSync : MonoBehaviour
{
    public string playerID;

    private Vector3 networkPosition;
    private Quaternion networkRotation;


    void Update()
    {
        transform.position =
        Vector3.Lerp(
        transform.position,
        networkPosition,
        Time.deltaTime * 10);


        transform.rotation =
        Quaternion.Lerp(
        transform.rotation,
        networkRotation,
        Time.deltaTime * 10);
    }


    public void ReceivePlayerData(
    Vector3 position,
    Quaternion rotation)
    {
        networkPosition = position;
        networkRotation = rotation;
    }
}