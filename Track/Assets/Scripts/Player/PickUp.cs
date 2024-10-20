using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private float _raycastDistance;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _raycastDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out IPickUpAble pickup))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    pickup.PickUpItem(gameObject);
                }
            }
        }
    }
}
