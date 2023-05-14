using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More then one instance of Inventory found!");
            return;
        }
        instance = this;
    }
    #endregion
    public delegate void OnItemChanget();
    public OnItemChanget onItemChangetCallback;
    public static Inventory instance;
    public List<Item> items = new List<Item>();
    public int space = 20;
    public bool Add(Item item)
    {
        Debug.Log("1");
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not enough room.");
                return false;
            }
            items.Add(item);
            if(onItemChangetCallback != null)
            onItemChangetCallback.Invoke();
        }
        return true;
    }
    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangetCallback != null)
            onItemChangetCallback.Invoke();
    }
}
