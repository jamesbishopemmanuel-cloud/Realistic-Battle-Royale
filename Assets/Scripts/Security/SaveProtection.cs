using UnityEngine;


public class SaveProtection : MonoBehaviour
{

    public string saveKey =
    "PLAYER_DATA";


    public void SecureSave(string data)
    {
        PlayerPrefs.SetString(
        saveKey,
        data);

        PlayerPrefs.Save();

        Debug.Log(
        "Secure save completed");
    }


    public string LoadSave()
    {
        return PlayerPrefs.GetString(
        saveKey);
    }

}