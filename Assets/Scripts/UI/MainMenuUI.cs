using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{

    public void StartBattle()
    {
        SceneManager.LoadScene("BattleMap");
    }


    public void OpenInventory()
    {
        Debug.Log("Inventory Opened");
    }


    public void OpenCharacter()
    {
        Debug.Log("Character Menu Opened");
    }


    public void ExitGame()
    {
        Application.Quit();
    }

}