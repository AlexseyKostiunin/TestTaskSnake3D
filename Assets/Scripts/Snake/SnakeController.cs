using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField] private List<Transform> _tails;

    [Range(0, 4)]
    [SerializeField] private float _speedSnake;

    [Range(0, 3)]
    [SerializeField] private float _bonesDistance;

    private Transform _transform; 
 
    private const string Horizontal = "Horizontal";


    private void Start()
    {       
        _transform = GetComponent<Transform>();
    } 

    private void Update()
    {
        MoveSnake(_transform.position + _transform.forward * _speedSnake);
        TurnSnake();
    }

    private void MoveSnake(Vector3 newPosition)
    {
        float sqrDistance = _bonesDistance * _bonesDistance;
        Vector3 previousPosition = _transform.position;

        foreach (var bone in _tails)
        {
            if((bone.position - previousPosition).sqrMagnitude > sqrDistance)
            {
                var temp = bone.position;
                bone.position = previousPosition;
                previousPosition = temp;
            }
            else
            {
                break;
            }
        }

        _transform.position = newPosition;
    }

    private void TurnSnake()
    {
        int timeReturnedValue = 4;
        float angel = Input.GetAxis(nameof(Horizontal)) * timeReturnedValue;
        _transform.Rotate(0, angel, 0);
    }
       
}
