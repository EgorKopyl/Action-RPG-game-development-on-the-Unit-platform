using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    public void Select()
    {
        Debug.Log("Picking up "+ item.name);
        bool wasPickUp = Inventory.instance.Add(item);
        if (wasPickUp)
           Destroy(gameObject);
    }

}
