using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private static Inventory Instance;

    public static Inventory GetInventory()
    {
        if (Instance == null)
            Instance = new Inventory();
        return Instance;
    }


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
        // This sets Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;
        //This hides the PauseMenu panel 
        inventory.gameObject.SetActive(false);

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
