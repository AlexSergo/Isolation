using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenController : MonoBehaviour
{
    public GameObject StatePanelOxygen;
    private float _oxygenLevel;
    public float OxygenLevel
    {
        get { return _oxygenLevel; }

        set
        {
            _oxygenLevel = value;
            StatePanelOxygen.gameObject.SetActive(true);
            StateBarController bar = StatePanelOxygen.transform.GetChild(0).GetComponent<StateBarController>();
            bar.TimeCount(OnOxygenEnded);
        }
    }

    private void OnOxygenEnded()
    {
        _oxygenLevel = 0;
        GameProcesses.IsGame = false;
        GameProcesses.Die("А про кислород ты не забыл? Ты задохнулся, друг! Пробуй еще раз, ты был близок к победе!");
    }
}
