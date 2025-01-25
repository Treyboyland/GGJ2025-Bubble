using UnityEngine;

public class BubbleMoveVertical : MonoBehaviour
{
    [SerializeField]
    Bubble bubble;

    [SerializeField]
    Rigidbody2D body;

    float timer = 0.0f;
    const float HORZ_FORCE = 30.0f;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        body.linearVelocity = new Vector2(0, bubble.Stats.Speed);
        ResetTimer();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timer = Mathf.Max(timer, 0.0f);

        if (timer <= 0.0f)
        {
            body.AddForce(new Vector2(Random.Range(-HORZ_FORCE, HORZ_FORCE), 0.0f));
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timer = Random.Range(0.5f, 2.0f);
    }
}
