using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject StatePanel;

    private List<Button> _items = new List<Button>();

    public void SetNewItem(GameObject item)
    {
        if (item.name == "Phone")
        {
            Phone phone = item.GetComponent<Phone>();
            phone.Energy = 100;
        }

        foreach (Button cell in _items)
        { 
            if (cell.GetComponent<Cell>().IsFree())
            {
                cell.GetComponent<Cell>().OccupationCell(item);
                return;
            }
        }
    }

    public void DeleteItem(GameObject obj)
    {
        foreach (Button item in _items)
        {
           if (item.GetComponent<Cell>().Staff.name == obj.name)
            {
                item.GetComponent<Cell>().FreeCell();
                Destroy(obj);
                return;
            }
        }
    }

    public void ItemsActive(bool value)
    {
        if (value && _items.Count == 0)
        {
            for (int i = 0; i < 4; i++)
                _items.Add(transform.GetChild(i).gameObject.GetComponent<Button>());
        }
    }
}
