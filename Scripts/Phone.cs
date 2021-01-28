using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject PhoneUI;
    public StateBarController BarEnergy;

    private float _energy = 100;
    public float Energy
    {
        get { return _energy; }
        set
        {
            _energy = value;
            BarEnergy.transform.parent.gameObject.SetActive(true);
        }
    }
    private GameObject _background;
    private GameObject _phoneMenu;

    private void Start()
    {
        _background = PhoneUI.transform.GetChild(0).gameObject;
        _phoneMenu = PhoneUI.transform.GetChild(1).gameObject;
    }
    public void ShowMenu()
    {
        if (_energy != 0)
        {
            _background.SetActive(true);
            _phoneMenu.SetActive(true);
        }
    }

    private void CloseMenu()
    {
        _background.SetActive(false);
        _phoneMenu.SetActive(false);
    }

    public void OutOfEnergy()
    {
        _energy = 0;
        CloseMenu();
        Inventory inventory = GameObject.FindGameObjectWithTag("Inventory").transform.GetChild(0).GetComponent<Inventory>();
        inventory.DeleteItem(gameObject);
    }
}
