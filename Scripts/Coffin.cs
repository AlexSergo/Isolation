using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffin : MonoBehaviour
{
    public BoxCollider2D[] boxes;
    private string _answer = "2123131332";
    private string _hiddenCodeToOpen;
    public string HidddenCodeToOpen 
    {
        get { return _hiddenCodeToOpen; }

        set
        {
            _hiddenCodeToOpen = value;
            CleanCode();
            if (_answer == _hiddenCodeToOpen)
            {
                Open();
                GameProcesses.TryToWakeUp(true);
            }
        }
    }

    private void Open()
    {
        GameObject.Find("CoffinButton").GetComponent<AudioSource>().Play();
        for (int i = 0; i < boxes.Length; i++) boxes[i].enabled = false;
        GetComponent<Animation>().Play("Open");
    }

    private void CleanCode()
    {
        for (int i = 0; i <_hiddenCodeToOpen.Length; i++)
            if (_hiddenCodeToOpen[i] != _answer[i])
            {
                _hiddenCodeToOpen = "";
                break;
            }
    }
}
