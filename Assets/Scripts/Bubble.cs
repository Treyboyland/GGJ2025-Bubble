using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    BubbleStats stats;

    [SerializeField]
    GameEvent bubblePoppedEvent;

    [SerializeField]
    GameEventBurstData bubbleBurstEvent;

    int currentHealth;

    public BubbleStats Stats => stats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        currentHealth = stats.Health;
    }

    void Damage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //TODO: Die
            bubblePoppedEvent.Invoke();
            bubbleBurstEvent.Invoke(new BubbleBurstData() { BubbleStats = stats, BurstLocation = transform.position });
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        //Best thing would probably be to fire off some event (arrow bubble collision taking both)
        var arrow = other.gameObject.GetComponent<Arrow>();
        if (arrow != null)
        {
            if (!arrow.IsPiercing)
            {
                arrow.gameObject.SetActive(false);
            }
            Damage(arrow.Damage);
        }
    }
}
