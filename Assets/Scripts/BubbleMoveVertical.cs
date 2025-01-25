using UnityEngine;

public class BubbleMoveVertical : MonoBehaviour
{
    [SerializeField]
    Bubble bubble;

    [SerializeField]
    Rigidbody2D body;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        body.linearVelocity = new Vector2(0, bubble.Stats.Speed);
    }
}
