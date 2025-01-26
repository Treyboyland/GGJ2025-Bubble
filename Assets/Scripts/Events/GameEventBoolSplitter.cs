using UnityEngine;

public class GameEventListenerBoolSplitter : MonoBehaviour
{
    [SerializeField]
    GameEvent trueEvent;

    [SerializeField]
    GameEvent falseEvent;

    public void SplitInvoke(bool value)
    {
        if (value)
        {
            trueEvent.Invoke();
        }
        else
        {
            falseEvent.Invoke();
        }
    }

}
