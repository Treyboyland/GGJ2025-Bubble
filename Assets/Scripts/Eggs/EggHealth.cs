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
			onDied.Invoke();
		}
	}
}
