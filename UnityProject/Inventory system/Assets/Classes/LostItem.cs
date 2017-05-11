using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostItem : MonoBehaviour {

    public Item item;

    private InventorySlot inventory;
	
	protected void SpecificInit() //Best void EU
    {
        inventory = FindObjectOfType<InventorySlot>();
    }

    protected void ImmediateReaction()
    {
        inventory.RemoveItem(item);
    }

}
