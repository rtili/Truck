using UnityEngine;

public class Interact : MonoBehaviour
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
            if (hit.collider.gameObject.TryGetComponent(out IInteractAble interact))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interact.InteractObject();
                }
            }
        }
    }
}
