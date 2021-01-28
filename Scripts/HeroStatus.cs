using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroStatus : MonoBehaviour
{
    public Zippo Zippo;
    public GameObject ButtonClose;
    public TextTips _text;
    public void Win()
    {
        ButtonClose.SetActive(true);
        _text.SetTextTips("ЭТО ПОБЕДА", "Дорогой игрок, ты прошел нашу игру! Мы благодарны тебе, что ты уделил нам время. Как видишь мы не профессиональные разработчики, но даже такие креаторы старались сделать все атмосферно. Эта разработка для нас целое испытание. Надеюсь тебе понравилось тут находиться. Мы ждем твой комент на dtf. Удачи, друг!");
        _text.ShowLastMessage();
    }

    public void UseFire()
    {
        Zippo.Throw(transform.position);
    }

    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
   

}
