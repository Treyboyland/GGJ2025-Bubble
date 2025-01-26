using UnityEngine;

public class RandomRotationOnStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var rigidBody = GetComponent<Rigidbody2D>();

        if (rigidBody)        
        {
            rigidBody.SetRotation(Random.rotation);
        }
        else
        {
            transform.localRotation = Random.rotation;
        }
    }
}
