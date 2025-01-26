using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class EggHealth : MonoBehaviour
{
	[SerializeField] int health;
	public int Health { get => health; }
	[SerializeField] UnityEvent<int> onDamaged;
	[SerializeField] UnityEvent onDied;

	//[Button(enabledMode:EButtonEnableMode.Playmode)]

	const float RED_FLASH_TIME = 0.25f;
	float redTimer = 0.0f;
	bool canFlash = false;

    private void Start()
    {
		redTimer = RED_FLASH_TIME;
	}
	private void Update()
	{
		if (canFlash)
		{
			redTimer -= Time.deltaTime;
			redTimer = Mathf.Max(redTimer, 0.0f);
		}

		if (redTimer <= 0.0f)
		{
			gameObject.GetComponent<SpriteRenderer>().color = Color.white;
			redTimer = RED_FLASH_TIME;
			canFlash = false;
		}
	}

	public void Damage()
	{
		--health;
		onDamaged.Invoke(health);

		if (health <= 0)
		{
			onDied.Invoke();
		}
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		var bubble = other.gameObject.GetComponent<Bubble>();
		if (bubble != null)
        {
			Damage();
			bubble.gameObject.SetActive(false);

			gameObject.GetComponent<SpriteRenderer>().color = Color.red;
			canFlash = true;
			redTimer = RED_FLASH_TIME;
		}
	}
}
