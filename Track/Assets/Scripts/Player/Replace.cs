using UnityEngine;

public class Replace : MonoBehaviour
{
    [SerializeField] private float _raycastDistance;
    private Inventory _inventory;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        _inventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _raycastDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out IReplaceAble replace))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    replace.ReplaceItem(_inventory.CurrentItem, _inventory);
                }
            }
        }
    }
}
