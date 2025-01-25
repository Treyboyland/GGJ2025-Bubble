using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    int initialLives;

    int currentLives;

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
        initialLives = currentLives;
    }

    public void Damage(int damage)
    {
        initialLives -= damage;
        if (initialLives <= 0)
        {
            initialLives = 0;
            //TODO: Die
            gameObject.SetActive(false);
        }
    }
}
