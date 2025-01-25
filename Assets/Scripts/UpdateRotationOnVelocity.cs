using UnityEngine;

public class UpdateRotationOnVelocity : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, body.linearVelocity.normalized));
    }
}
