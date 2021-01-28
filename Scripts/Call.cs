using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Call : MonoBehaviour
{
    public Text Name;
    public TextTips Message;
    public StateBarController EnergyBar;
    public Phone Phone;

    private string _helpText = "Спаси меня, я очнулся в гробу!";

    public void Calling()
    {
        GameObject.Find("PhoneButton").GetComponent<AudioSource>().Play();
        Message.gameObject.SetActive(true);
        switch (Name.text)
        {
            case "Братишка":
                Message.SetTextTips("Звонок " + Name.text, Name.text + ", " + _helpText + "\n\n" + "- Выезжаю, держись, братишка!");
                Bro bro = GameObject.FindGameObjectWithTag("Bro").GetComponent<Bro>();
                bro.Help();
                break;
            default:
                Message.SetTextTips("Звонок " + Name.text, Name.text + ", " + _helpText + "\n\n" + "- Прекратите свои шутки!");
                break;
        }
        Message.ShowMessage();
        ChangeEnergy();
    }

    private void ChangeEnergy()
    {
        EnergyBar.CutTime(50, Phone.OutOfEnergy);
    }
}
