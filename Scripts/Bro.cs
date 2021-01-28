using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bro : MonoBehaviour
{
    public Vector2 Grave;
    public float Speed;

    private int _timeToGo = 15;
    public void Help()
    {
        StartCoroutine(GoToСemetery());
    }

    private IEnumerator GoToСemetery()
    {
        yield return new WaitForSeconds(_timeToGo);
        StartCoroutine(Walk());
    }   
    
    private IEnumerator Walk()
    {
        gameObject.GetComponent<Animator>().SetBool("Run", true);
        while (Mathf.Abs(transform.position.x - Grave.x) > 0.5f)
        {
            transform.Translate(Vector2.right * Speed);
            yield return new WaitForFixedUpdate();
        }
        gameObject.GetComponent<Animator>().SetBool("Run",false);
    }
}
