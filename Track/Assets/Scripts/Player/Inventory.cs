using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, IInventoryAble
{
    [SerializeField] private Transform _inventory;
    private int _maxItems = 3;
    private List<GameObject> _items = new ();
    private int _currentIndex;
    private GameObject _currentItem;
    public GameObject CurrentItem => _currentItem;

    public void AddItem(GameObject item)
    {
        if (_items.Count >= _maxItems)
        {
            Debug.Log("Not enough space");
            return;
        }

        item.transform.position = _inventory.position;
        item.transform.SetParent(_inventory);
        item.SetActive(false);
        _items.Add(item);

        if (_items.Count == 1)
        {
            _currentIndex = 0;
            _items[_currentIndex].SetActive(true);
            _currentItem = _items[_currentIndex];
        }
    }

    public void RemoveItem(GameObject item)
    {
        _items.Remove(item);
        _currentItem = null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))  SwitchItem(0); 
        if (Input.GetKeyDown(KeyCode.Alpha2))  SwitchItem(1); 
        if (Input.GetKeyDown(KeyCode.Alpha3))  SwitchItem(2); 
    }

    private void SwitchItem(int index)
    {
        if (index >= _items.Count) return;
        if (_currentItem != null) _currentItem.SetActive(false);

        _currentIndex = index;
        _items[_currentIndex].SetActive(true);

        _currentItem = _items[_currentIndex];
    }
}
