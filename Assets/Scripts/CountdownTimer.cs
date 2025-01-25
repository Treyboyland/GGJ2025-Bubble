using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] UnityEvent onDone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        onDone.Invoke();
    }
}
