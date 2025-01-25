using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class EggHealth : MonoBehaviour
{
	[SerializeField] int health;
	public int Health { get => health; }
	[SerializeField] UnityEvent<int> onDamaged;
	[SerializeField] UnityEvent onDied;

	[Button(enabledMode:EButtonEnableMode.Playmode)]
	public void Damage()
	{
		--health;
		onDamaged.Invoke(health);

		if (health <= 0)
		{
			//onDied.Invoke();
			EggDie();
		}
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		var bubble = other.gameObject.GetComponent<Bubble>();
		if (bubble != null)
        {
			Damage();
			bubble.gameObject.SetActive(false);
        }
	}

	void EggDie()
    {
		// subtract points too
		Destroy(this.gameObject);
    }
}
