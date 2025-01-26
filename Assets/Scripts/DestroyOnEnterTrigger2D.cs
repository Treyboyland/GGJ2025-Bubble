using UnityEngine;

public class DestroyOnEnterTrigger2D : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet gameObjects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (gameObjects.Contains(collider.gameObject))
        {
            Destroy(collider.gameObject);
        }
    }
}
