using UnityEngine;
using System.Collections.Generic;


public class InventoryUI : MonoBehaviour
{

    public List<string> inventory =
    new List<string>();


    public void AddItem(string item)
    {
        inventory.Add(item);

        Debug.Log(
        item + " added");
    }


    public void RemoveItem(string item)
    {
        inventory.Remove(item);
    }


    public void ShowInventory()
    {
        foreach(string item in inventory)
        {
            Debug.Log(item);
        }
    }

}