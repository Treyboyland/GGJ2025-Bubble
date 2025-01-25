using System.Collections.Generic;
using UnityEngine;

public class GameEvent<T> : ScriptableObject
{
    List<GameEventListener<T>> listeners = new List<GameEventListener<T>>();

    public T Value;

    public void AddListener(GameEventListener<T> listener)
    {
        if (listener == null)
        {
            return;
        }
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void RemoveListener(GameEventListener<T> listener)
    {
        listeners.Remove(listener);
    }

    public void Invoke()
    {
        foreach (var listener in listeners)
        {
            listener.Response.Invoke(Value);
        }
    }

    public void Invoke(T value)
    {
        Value = value;
        Invoke();
    }
}
