using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public SecretCode SecretCode;
    public GameObject BoxUI;

    private void Start()
    {
        BoxUI.transform.GetChild(1).gameObject.SetActive(false);
    }
    private void OnMouseUpAsButton()
    {
        BoxUI.gameObject.SetActive(true);
    }

    public void CloseBox()
    {
        SecretCode.Answer = "";
        BoxUI.gameObject.SetActive(false);
    }
}
