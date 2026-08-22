using UnityEngine;
using System.Collections.Generic;


public class CloudInventory : MonoBehaviour
{

    public List<string> items =
    new List<string>();


    public void SaveItem(string item)
    {
        items.Add(item);

        Debug.Log(
        "Saved to cloud: " + item);
    }


    public void LoadInventory()
    {
        Debug.Log(
        "Inventory loaded");
    }

}