using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentItem : MonoBehaviour
{
    private bool _isUsing = false;
    public virtual void UseIt(bool value)
    {
        _isUsing = value;
        if (_isUsing)
            StartCoroutine(SetPosition());
    }
    public IEnumerator SetPosition()
    {
        while (_isUsing)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;
            yield return new WaitForEndOfFrame();
        }
    }
}
