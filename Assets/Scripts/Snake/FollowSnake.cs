using UnityEngine;

public class FollowSnake : MonoBehaviour
{
    [SerializeField] private Transform _targetCamera;
    [SerializeField] private Transform _cameraTransform;

    private void LateUpdate()
    {
        _cameraTransform.position = _targetCamera.position + new Vector3(0, 5, -5);
    }
}
