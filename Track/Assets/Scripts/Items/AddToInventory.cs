using UnityEngine;

public class AddToInventory : MonoBehaviour, IPickUpAble
{
    public void PickUpItem(GameObject handler)
    {
        if(handler.TryGetComponent(out IInventoryAble inventory))
            inventory.AddItem(gameObject);
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
