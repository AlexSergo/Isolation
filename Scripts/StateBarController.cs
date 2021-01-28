using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StateBarController : MonoBehaviour
{
    public float Speed;

    public delegate void OutOfFuel();

    private OutOfFuel _outOfFuel;

    public void TimeCount(OutOfFuel outOfFuel)
    {
        _outOfFuel = outOfFuel;
        StartCoroutine(TickTime(0, Speed));
    }

    public void CutTime(float value, OutOfFuel outOfFuel = null)
    {
        if (_outOfFuel == null)
          _outOfFuel = outOfFuel;
        transform.GetComponent<Image>().fillAmount -= value / 100;
        if (transform.GetComponent<Image>().fillAmount == 0)
            OilEnded();
    }

    private IEnumerator TickTime(float value, float speed)
    {
        while (GameProcesses.IsGame && transform.GetComponent<Image>().fillAmount > value && transform.GetComponent<Image>().fillAmount != 0)
        {
                transform.GetComponent<Image>().fillAmount -= speed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
        }
        if (GameProcesses.IsGame)
            OilEnded();
    }

    private void OilEnded()
    {
        print(transform.GetComponent<Image>().fillAmount);
        if (_outOfFuel != null)
          _outOfFuel.Invoke();
    }
}
