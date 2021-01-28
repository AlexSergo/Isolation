using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    public GameObject PaperPanel;
    public void ShowPicture()
    {
        PaperPanel.gameObject.SetActive(true);
        PaperPanel.transform.GetChild(0).gameObject.SetActive(true);
    }
}
