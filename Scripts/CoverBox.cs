using System.Collections;
using UnityEngine;

public class CoverBox : MonoBehaviour
{
    public GameObject Box;
    private Animation _coverOpen;

    private void Start()
    {
        _coverOpen = transform.GetComponent<Animation>();
    }
    public void Open()
    {
        Box.SetActive(true);
        _coverOpen.Play();
        StartCoroutine(DestroyCover());
    }

    private IEnumerator DestroyCover()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
