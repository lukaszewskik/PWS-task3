using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopComponent : MonoBehaviour
{
    InventoryComponent inventory;

    private void Start()
    {
        inventory = GetComponent<InventoryComponent>();
    }

    void BuyItem(Item item, InventoryComponent targetInventory)
    {
        if (inventory.money >= item.value)
        {
            inventory.money -= item.value;
            targetInventory.money += item.value;
            inventory.items.Add(item);
            targetInventory.items.Remove(item);
        }
    }

    void SellItem(Item item, InventoryComponent targetInventory)
    {
        if (targetInventory.money >= item.value)
        {
            inventory.money += item.value;
            targetInventory.money -= item.value;
            inventory.items.Remove(item);
            targetInventory.items.Add(item);
        }
    }
}
