using System;
using UnityEngine;
using UnityEngine.UI;

public class TextTips : MonoBehaviour
{
    public Text Header;
    public Text Body;

    public void SetTextTips(string HeaderText, string BodyText)
    {
        Header.text = HeaderText;
        Body.text = BodyText;
    }

    public void SetStartText()
    {
        string startTextHeader = "КОГО-ТО ПОХРОНИЛИ";
        string startTextBody = "ПРИВЕТ, ДОРОГОЙ ДРУГ! ТЫ ОЧУТИЛСЯ В ГРОБУ. ДА, ДА, НЕ УДИВЛЯЙСЯ. " +
        "ТВОЯ ЗАДАЧА - ВЫБРАТЬСЯ ОТСЮДА КАК МОЖНО СКОРЕЕ. НО... ТЫ ВЕДЬ НЕ БЕССМЕРТНЫЙ, ПРАВДА? ПОЭТОМУ ТЕБЕ НАДО СЛЕДИТЬ " +
        "ЗА СВОИМИ ПОКАЗАТЕЛЯМИ. В ОБЩЕМ УДАЧИ В ЭТОМ ДЕЛЕ. АХ ДА, ТЕБЕ НЕ ПОМЕШАЛО БЫ ОСМОТРЕТЬ СВОИ КАРМАНЫ, ДА И " +
        "ВПРИНЦИПЕ ОСМОТРЕТЬСЯ. ВДРУГ ЧТО ПОЛЕЗНОЕ НАЙДЕШЬ.";

        SetTextTips(startTextHeader, startTextBody);
     }

    public void ShowLastMessage()
    {
        GameObject closeButton = transform.GetChild(0).gameObject;
        closeButton.SetActive(false);
        gameObject.SetActive(true);

    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void ShowMessage()
    {
        gameObject.SetActive(true);
    }
}
