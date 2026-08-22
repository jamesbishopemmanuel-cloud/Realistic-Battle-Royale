using UnityEngine;
using System.Collections.Generic;


public class FriendsSystem : MonoBehaviour
{

    public List<string> friends =
    new List<string>();


    public void AddFriend(string id)
    {
        friends.Add(id);

        Debug.Log(
        id + " added");
    }


    public void RemoveFriend(string id)
    {
        friends.Remove(id);
    }


    public bool IsFriend(string id)
    {
        return friends.Contains(id);
    }

}