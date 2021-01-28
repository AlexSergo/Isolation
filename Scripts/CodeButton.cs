using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeButton : MonoBehaviour
{
    public SecretCode SecretCode;
    private string _code;

    private void Start()
    {
        _code = transform.GetChild(0).GetComponent<Text>().text;
        transform.GetComponent<Button>().onClick.AddListener(EnterCode);
    }
    public void EnterCode()
    {
            SecretCode.Answer += _code;
    }
}
