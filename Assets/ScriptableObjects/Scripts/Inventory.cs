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
    //The variable to manage the state of the inventory
    private bool isActive; 
    public GameObject inventory;
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Escape))
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
        Mouse.current.WarpCursorPosition(mcPos);
        // This sets Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;
        //This hides the PauseMenu panel 
        inventory.gameObject.SetActive(false);
        //Hide the cursor
        Cursor.visible = false;
    }

}
