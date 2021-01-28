using UnityEngine;

public class Shovel : CurrentItem
{
    private void OnMouseDown()
    {
        GameProcesses.SetItem(gameObject);
        GetComponent<PolygonCollider2D>().enabled = false;
    }

    public void Retrieve()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(transform.parent.position.x, transform.parent.position.y - 0.5f);
        GetComponent<PolygonCollider2D>().enabled = true;
    }

    public override void UseIt(bool value)
    {
        base.UseIt(value);
        Retrieve();
    }
}
