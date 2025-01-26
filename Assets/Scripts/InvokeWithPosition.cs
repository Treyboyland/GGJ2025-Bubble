using UnityEngine;

public class InvokeWithPosition : MonoBehaviour
{
    [SerializeField] GameEventVector2 gameEvent;

    public void Invoke()
    {
        gameEvent.Invoke(transform.position);
    }
}
