using UnityEngine;

public class TruckDoor : MonoBehaviour, IInteractAble
{
    public void InteractObject()
    {
        GetComponent<Animator>().SetTrigger("Open");
    }
}
