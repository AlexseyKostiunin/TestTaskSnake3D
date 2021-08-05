using UnityEngine;

public class SnakeEat : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Food food))
        {
            Destroy(collision.gameObject);
        }
    }
}
