using UnityEngine;

public class LootItem : MonoBehaviour
{
    public string itemName;

    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        Debug.Log("Collected: " + itemName);
        Destroy(gameObject);
    }
}