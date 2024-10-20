using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name;
    public string Name => _name;
}
