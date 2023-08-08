using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (fileName = "New Item",menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool showInventory = true;
    BlueNoteUI blueNote;
  
    
   
    public void Use()//Use Item
    {
        if(name.Equals("Keys"))
        {
            door1.doorKey = true;
            Debug.Log(door1.doorKey);
        }

        if(name.Equals("BlueNote"))
        {
            blueNote = BlueNoteUI.instance;
            blueNote.Shownote();
            gB503.active = true;
            
        }
        

    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
