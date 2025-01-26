using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CountdownTimer))]
public class EggHatchingFacade : MonoBehaviour
{
    [SerializeField] UnityEvent startHatching;

    public void StartHatching() => startHatching.Invoke();

    public bool IsHatching => GetComponent<CountdownTimer>()?.enabled ?? false;
}
