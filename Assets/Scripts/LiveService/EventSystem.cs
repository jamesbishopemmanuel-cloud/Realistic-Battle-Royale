using UnityEngine;
using System.Collections.Generic;


public class EventSystem : MonoBehaviour
{

    public List<string> activeEvents =
    new List<string>();


    public void AddEvent(string eventName)
    {
        activeEvents.Add(eventName);

        Debug.Log(
        "Event Added: " + eventName);
    }


    public void RemoveEvent(string eventName)
    {
        activeEvents.Remove(eventName);
    }

}