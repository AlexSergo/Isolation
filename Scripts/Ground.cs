using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        if (GameProcesses.CurrentItem != null && GameProcesses.CurrentItem.GetComponent<Shovel>() != null)
        {
            GameObject.Find("DirtButton").GetComponent<AudioSource>().Play();
            GameProcesses.TryToWakeUp(false);
            Destroy(gameObject);          
        }
    }
}
