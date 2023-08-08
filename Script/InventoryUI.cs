using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUI;
    public Transform itemParent;
    Inventory inventory;
    public AudioSource audioSource;
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else 
            { 
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            
        }
        UpdateUI();
    }
    public void UpdateUI()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        for(int i=0;i<slots.Length; i++)
        {
            if(i<inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    // Update is called once per frame
    
}
