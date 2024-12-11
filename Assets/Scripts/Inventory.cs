using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using System.Runtime.InteropServices;
using Unity.Collections;

public class Inventory : MonoBehaviour
{
    //This array contains the items on the inventory at the moment
    public int maxItems = 5;
    public List<Item> items = new();
    //The variable to manage the state of the inventory
    private bool isActive; 
    public GameObject inventory;
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.I))
        {
            //This toggles inventory on Escape key press
            isActive = !isActive;
            if (isActive)
            {
                Show();
            }
            else
            {
                Hide();
            } 
        }
    }
    public void Show()
    {
        // This shows the inventory
        inventory.gameObject.SetActive(true);
    }

    public void Hide()
    {
        //This sets moves the cursor to the character when resuming the game
        Vector2 mcPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        //Mouse.current.WarpCursorPosition(mcPos);
        // This sets Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;
        //This hides the PauseMenu panel 
        inventory.gameObject.SetActive(false);
        //Hide the cursor
        Cursor.visible = false;
    }

    public bool AddItem(Item itemToAdd)
    {
        // Finds an empty slot if there is one
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                return true;
            }
        }

        // Adds a new item if the inventory has space
        if (items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }

        Debug.Log("No space in the inventory");
        return false;
    }

    
}