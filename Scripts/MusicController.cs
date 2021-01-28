using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip _clickSound;
    public AudioClip GamePlayMusic_1;
    public AudioClip GamePlayMusic_2;

    public AudioSource MainMusic;
    public AudioSource SoundButton;
    public void ClickSound()
    {
        SoundButton.Play();
    }
    public void MainMusicSet()
    {
        MainMusic.Stop();
        MainMusic.volume = 0.8f;
        MainMusic.clip = GamePlayMusic_1;
        MainMusic.Play();
    }

    public void MainMusicSetSecond()
    {
        MainMusic.Stop();
        MainMusic.volume = 0.8f;
        MainMusic.clip = GamePlayMusic_2;
        MainMusic.Play();
    }

}
