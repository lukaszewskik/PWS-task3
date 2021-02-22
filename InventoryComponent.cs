using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    public int money;
    public List<Item> items;

    public void ShowInventory()
    {
        Debug.Log("Money: " + money);
        foreach (Item item in items)
        {
            Debug.Log(item.name + ", " + item.description);
        }
    }

    void SelectItem(Item item)
    {
        
    }




}
