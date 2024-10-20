using UnityEngine;

public class ReplaceObject : MonoBehaviour, IReplaceAble
{
    [SerializeField] private string _name;

    public void ReplaceItem(GameObject replaceableItem, Inventory inventory)
    {
        if (replaceableItem.GetComponent<Item>().Name == _name)
        {
            inventory.RemoveItem(replaceableItem);
            replaceableItem.transform.position = gameObject.transform.position;
            replaceableItem.transform.SetParent(null);
            gameObject.SetActive(false);
        }
    }
}
