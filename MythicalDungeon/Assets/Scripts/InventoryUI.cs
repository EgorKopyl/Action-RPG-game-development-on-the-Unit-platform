using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParents;
    Inventory inventory;
    InventorySlot[] slots;
    


    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangetCallback += UpdateUI;
        slots = itemsParents.GetComponentsInChildren<InventorySlot>();
    }

    void Update()
    { 
        
    }
    void UpdateUI()
    {
        for (int i=0; i < slots.Length; i++)
        {
            if(i< inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }else
            {
                slots[i].ClearSlot();
            }
        }

    }
}
