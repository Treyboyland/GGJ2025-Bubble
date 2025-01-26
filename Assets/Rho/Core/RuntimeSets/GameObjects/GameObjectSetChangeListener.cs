using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace rho
{
    /// <summary>
    /// If the runtime set changes, invoke the onChange UnityEvent.
    /// </summary>
    public class GameObjectSetChangeListener : MonoBehaviour
    {
        [SerializeField] RuntimeGameObjectSet _runtimeSet = null;
        [SerializeField] UnityEvent<RuntimeGameObjectSet> _onChange;
        [SerializeField] UnityEvent<RuntimeGameObjectSet> _onItemAdded;
        [SerializeField] UnityEvent<RuntimeGameObjectSet> _onItemRemoved;

        void SetChanged(RuntimeSet<GameObject> sender)
        {
            _onChange.Invoke(_runtimeSet);
        }

        void ItemAdded(RuntimeSet<GameObject> sender)
        {
            _onItemAdded.Invoke(_runtimeSet);
        }

        void ItemRemoved(RuntimeSet<GameObject> sender)
        {
            _onItemRemoved.Invoke(_runtimeSet);
        }

        void OnEnable()
        {
            _runtimeSet.SetChanged += SetChanged;
            _runtimeSet.ItemAdded += ItemAdded;
            _runtimeSet.ItemRemoved += ItemRemoved;
        }

        void OnDisable()
        {
            _runtimeSet.SetChanged -= SetChanged;
            _runtimeSet.ItemAdded -= ItemAdded;
            _runtimeSet.ItemRemoved -= ItemRemoved;
        }
    }
}