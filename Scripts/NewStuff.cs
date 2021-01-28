using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStuff : MonoBehaviour
{
    public GameObject Object;

    private void OnMouseDown()
    {
        AddToInventory();
        Destroy(gameObject);
    }
    public void AddToInventory()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Inventory").transform.GetChild(0).GetComponent<Inventory>();
        inventory.gameObject.SetActive(true);
        inventory.ItemsActive(true);
        inventory.SetNewItem(Object);
    }
}
