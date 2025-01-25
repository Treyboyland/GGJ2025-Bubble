using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    ArrowStats stats;

    [SerializeField]
    Rigidbody2D body;

    public int Damage => stats.Damage;

    public bool IsPiercing => stats.Piercing;

    float currentSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        body.linearVelocity = transform.up * currentSpeed;
    }

    public void SetSpeed(float angle, float speed)
    {
        transform.eulerAngles = new Vector3(0, 0, angle);
        currentSpeed = speed;
    }
}
