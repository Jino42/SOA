using System.Collections.Generic;
using UnityEngine;

namespace SOA
{

    public abstract class BaseGameEvent<T> : BaseGameEvent
    {
        private readonly List<IGameEventListener<T>> _typedListeners = new List<IGameEventListener<T>>();

        [SerializeField]
        protected T _debugValue = default(T);

        public void Raise(T value)
        {
            for (int i = _typedListeners.Count - 1; i >= 0; i--)
                _typedListeners[i].OnEventRaised(value);

            for (int i = _listeners.Count - 1; i >= 0; i--)
                _listeners[i].OnEventRaised();

        }
        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!_typedListeners.Contains(listener))
                _typedListeners.Add(listener);
        }
        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (_typedListeners.Contains(listener))
                _typedListeners.Remove(listener);
        }
        public override void UnregisterAll()
        {
            _typedListeners.Clear();
            _listeners.Clear();
        }
    }

    public abstract class BaseGameEvent : SOA_BaseObject
    {
        protected readonly List<IGameEventListener> _listeners =
            new List<IGameEventListener>();

        public void Raise()
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
                _listeners[i].OnEventRaised();
        }

        public void RegisterListener(IGameEventListener listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener listener)
        {
            if (_listeners.Contains(listener))
                _listeners.Remove(listener);
        }

        public virtual void UnregisterAll()
        {
            _listeners.Clear();
        }
    }
}