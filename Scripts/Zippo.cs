using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zippo : CurrentItem
{
    public StateBarController StateBarOxygen;
    public GameObject FirePrefab;

    private bool _isFire = false;

    public override void UseIt(bool value)
    {
        base.UseIt(value);
        if (!value)
         _isFire = false;
        else
        {
            _isFire = true;
            StartCoroutine(Fire());
        }    
    }

    public void Throw(Vector2 startPosition)
    {
        transform.position = startPosition;
        gameObject.SetActive(true);
        StartCoroutine(Fire());
        GetComponent<Animation>().Play("Fall");
    }

    private void DestroyAll()
    {
        GameObject.Find("ZippoButton").GetComponent<AudioSource>().Play();
        FirePrefab.SetActive(true);
        gameObject.SetActive(false);
    }

    private IEnumerator Fire()
    {
        // Горение вкл
        if (GameProcesses.IsGame)
        {
            while (_isFire)
            {
                StateBarOxygen.CutTime(0.5f);
                yield return new WaitForFixedUpdate();
            }
        }
    }
}
