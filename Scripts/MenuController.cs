using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject MenuPanel;     //Панель меню
    public GameObject SettingsPanel; //Панель настройки

    public MoveCamera Camera;        //Скрипт движения камеры

    [Header("Объекты, которые должны пропасть после нажатия кнопки Старт")]
    public Animator[] DisappearObjects;  

    public void StartGame()
    {
        StartCoroutine(Camera.Move());

        for (int i = 0; i < DisappearObjects.Length; i++) DisappearObjects[i].SetTrigger("Exit");

        if (GameProcesses.IsGame)
         MenuPanel.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    #region SETTINGS
    public void SettingsOpen()
    {
        SettingsPanel.SetActive(true);
    }
    public void SettingClose()
    {
        SettingsPanel.SetActive(false);
    }
    public void MusicValue()
    {
        AudioListener.volume = GameObject.Find("MusicSlider").GetComponent<Slider>().value;
    }
    public void OpenVkMisha()
    {
        Application.OpenURL("https://vk.com/mchix");
    }
    public void OpenVkSasha()
    {
        Application.OpenURL("https://vk.com/ader_alexandr");
    }
    public void OpenVkUlia()
    {
        Application.OpenURL("https://vk.com/vishenka3120");
    }
    #endregion
}