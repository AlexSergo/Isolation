using System;
using UnityEngine;

public class GameProcesses : MonoBehaviour
{
    public static GameObject Message;

    public static GameObject CurrentItem { get; private set; }

    private static bool _isGame = false;
    private static TextTips _text;

    public static bool IsGame
    {
        get
        {
            return _isGame;
        }

        set
        {
            _isGame = value;
            if (_isGame)
            {
                _text = GameObject.FindGameObjectWithTag("TextTips").transform.GetChild(0).GetComponent<TextTips>();
                OxygenStart();
                ShowStartText();
            }
            else
            {
                HideInventory();
            }
        }
    }

    private static void HideInventory()
    {
        GameObject inventory = GameObject.FindGameObjectWithTag("Inventory");
        inventory.transform.GetChild(0).gameObject.SetActive(false);
    }

    public static void SetItem(GameObject item)
    {
        if (CurrentItem != item)
        {
            HideCurrentItem();
            CurrentItem = item;
            CurrentItem.gameObject.SetActive(true);
            CurrentItem.GetComponent<CurrentItem>().UseIt(true);
        }
        else CurrentItem = null;
    }

    public static void HideCurrentItem()
    {
        if (CurrentItem != null)
        {
            CurrentItem.SetActive(false);
            CurrentItem.GetComponent<CurrentItem>().UseIt(false);
            CurrentItem = null;
        }
    }

    public static void TryToWakeUp(bool isHiddenCodeInputed)
    {
        GameObject[] ground = null;
        ground = GameObject.FindGameObjectsWithTag("Ground");
        if (isHiddenCodeInputed)
        {
            if (ground.Length == 0)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                player.GetComponent<Character>().WakeUp();
            }
            else
            {
                Die("Кого то придавило камнями. Будь аккуратен! Ты можешь попробовать еще раз.");
            }
            IsGame = false;
        }
    }

    public static void Die(string body)
    {       
        _text.SetTextTips("Земля пухом", body);
        _text.ShowLastMessage();
        _text.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    private static void ShowStartText()
    {
       
        _text.SetStartText();
        _text.ShowMessage();
    }

    private static void OxygenStart()
    {
        OxygenController oxygen = GameObject.FindGameObjectWithTag("Oxygen").GetComponent<OxygenController>();
        oxygen.OxygenLevel = 100;
    }
}
