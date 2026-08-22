using UnityEngine;


public class DailyLoginReward : MonoBehaviour
{

    public int loginDays;


    public void Login()
    {
        loginDays++;


        Debug.Log(
        "Login Day: "
        + loginDays);
    }


    public int GetReward()
    {
        return loginDays * 100;
    }

}