using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public int maxSlots = 10;

    public List<string> items = new List<string>();

    public void AddItem(string item)
    {
        if(items.Count < maxSlots)
        {
            items.Add(item);
            Debug.Log(item + " added");
        }
        else
        {
            Debug.Log("Inventory Full");
        }
    }


    public void RemoveItem(string item)
    {
        items.Remove(item);
    }
}