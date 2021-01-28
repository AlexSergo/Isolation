using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<ParticleSystem>().isPlaying && GetComponent<AudioSource>().isPlaying == false) GetComponent<AudioSource>().Play();
    }
}
