using UnityEngine;


public class MiniMapSystem : MonoBehaviour
{

    public Transform player;


    void LateUpdate()
    {
        Vector3 position =
        player.position;


        transform.position =
        new Vector3(
        position.x,
        transform.position.y,
        position.z);
    }

}