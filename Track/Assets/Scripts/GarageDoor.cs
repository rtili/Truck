using UnityEngine;

public class GarageDoor : MonoBehaviour, IInteractAble
{
    public void InteractObject()
    {
        GetComponent<Animator>().SetTrigger("Open");
    }
}
