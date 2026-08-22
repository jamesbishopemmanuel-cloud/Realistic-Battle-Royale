using UnityEngine;


public class KillFeedSystem : MonoBehaviour
{

    public void AddKill(
    string killer,
    string victim)
    {

        Debug.Log(
        killer +
        " eliminated "
        +
        victim);

    }

}