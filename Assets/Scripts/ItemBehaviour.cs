using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public Item Item;


    void OnMouseDown()
    {
        Inventory.GetInventory().AddItem(Item);

        Destroy(this);

    }




}
