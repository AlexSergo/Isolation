using UnityEngine;

public class CoverOfCoffinController : MonoBehaviour
{
    public Animation Cover;
    public Coffin Coffin;
    public string Name;
    public string HiddenCode;

    private void OnMouseDown()
    {
        GameObject.Find("KnifeButton").GetComponent<AudioSource>().Play();
        Cover.Play(Name);
        if (GameProcesses.CurrentItem != null && GameProcesses.CurrentItem.GetComponent<Knife>() != null)
        {
            Coffin.HidddenCodeToOpen += HiddenCode;
            
        }
    }
}
