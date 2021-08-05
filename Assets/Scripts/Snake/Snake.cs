using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour 
{    
    [SerializeField] private MeshRenderer[] _snake;

    private string NowNameControlPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PointChangeMaterial materialSetPoint))
        {
            NowNameControlPoint = other.gameObject.name;

            foreach (var snake in _snake)
            {
                snake.GetComponent<MeshRenderer>().material =
                GameObject.Find(NowNameControlPoint).GetComponent<MeshRenderer>().material;
            }
        }
    }
}

