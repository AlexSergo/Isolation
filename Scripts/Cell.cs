using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public GameObject Staff;

    public void GetItem()
    {
        if (Staff != null)
        {
            if (GameProcesses.CurrentItem != null && Staff.name == GameProcesses.CurrentItem.name)
            {
                GameProcesses.HideCurrentItem();
                return;
            }
            GameProcesses.HideCurrentItem();
            switch (Staff.name)
            {
                case "Paper":                    
                    Staff.GetComponent<Paper>().ShowPicture();
                    return;
                case "Phone":
                    Staff.GetComponent<Phone>().ShowMenu();
                    break;
                default:
                    GameProcesses.SetItem(Staff);
                    break;
            }
        }
    }

    public void OccupationCell(GameObject item)
    {
        Image image = transform.GetChild(0).GetComponent<Image>();
        image.sprite = item.GetComponent<SpriteRenderer>().sprite;
        image.color = new Color(255, 255, 255, 255);
        Staff = item;
    }

    public bool IsFree()
    {
        return Staff == null ? true : false;
    }

    public void FreeCell()
    {
        Staff = null;
        transform.GetChild(0).GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }
}
