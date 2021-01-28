using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    public List<GameObject> Items;
    public GameObject Inventory;
    private void OnMouseDown()
    {
        Inventory.transform.GetChild(0).gameObject.SetActive(true);
        Inventory inventory = Inventory.transform.GetChild(0).GetComponent<Inventory>();
        inventory.ItemsActive(true);
        if (Items.Count != 0)
        {
            inventory.SetNewItem(Items[Items.Count - 1]);
            Items.RemoveAt(Items.Count - 1);
        }
    }
}
