using System.Linq;
using UnityEngine;

/// <summary>
/// Listen for Egg deaths and always ensure one egg is in the hatching process
/// </summary>
public class EggHatchingHandler : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet eggs;

    void OnEggRemoved(rho.RuntimeSet<GameObject> eggs) => EnsureEggIsHatching();

    public void EnsureEggIsHatching()
    {
        var allTimers = eggs.Select(e => e.GetComponent<CountdownTimer>()).Where(e => e != null && e.gameObject != null);
        if (allTimers.Count() > 0 && !allTimers.Any(t => t.enabled))
        {
            allTimers.First().enabled = true;
        }
    }

    void OnEnable()
    {
        eggs.ItemRemoved += OnEggRemoved;
    }

    void OnDisable()
    {
        eggs.ItemRemoved -= OnEggRemoved;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnsureEggIsHatching();
    }
}
