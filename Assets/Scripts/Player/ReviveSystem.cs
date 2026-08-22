using UnityEngine;


public class ReviveSystem : MonoBehaviour
{

    public bool knocked;


    public void KnockPlayer()
    {
        knocked = true;

        Debug.Log(
        "Player knocked");
    }


    public void RevivePlayer()
    {
        knocked = false;

        Debug.Log(
        "Player revived");
    }

}