using System.Collections;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 _endPosition, _startPosition;

    private float _progress, _step;

    private void Start()
    {
        _endPosition = new Vector3(transform.position.x, 0, -10);
        _startPosition = transform.position;
        _step = 0.004f;
    }
    public IEnumerator Move()
    {
        while (transform.position.y > _endPosition.y)
        {
            transform.position = Vector3.Lerp(_startPosition, _endPosition, _progress);
            _progress += _step;
            yield return new WaitForFixedUpdate();
        }
        GameProcesses.IsGame = true;
    }
}
