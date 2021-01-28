using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : MonoBehaviour
{
    public SecretCode SecretCode;
    public CoverBox Cover;
    private void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(EnterCode);
    }

    public void EnterCode()
    {
        if (SecretCode.Answer == SecretCode.Code)
        {
            GameObject.Find("SuccessButton").GetComponent<AudioSource>().Play();
            Cover.Open();
        }
        else
        {
            GameObject.Find("ErrorButton").GetComponent<AudioSource>().Play();
            SecretCode.Answer = "";
        }
    }
}
