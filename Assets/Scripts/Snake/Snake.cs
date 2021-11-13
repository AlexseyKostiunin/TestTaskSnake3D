using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour 
{    
    [SerializeField] private MeshRenderer[] _snake;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PointChangeMaterial materialSetPoint))
        {
            foreach (var snake in _snake)
            {
                snake.GetComponent<MeshRenderer>().material =
                    other.gameObject.GetComponent<MeshRenderer>().material;
            }
        }
    }
}

