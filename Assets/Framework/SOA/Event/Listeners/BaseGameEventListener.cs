using UnityEngine;
using UnityEngine.Events;

namespace SOA
{
    public abstract class BaseGameEventListener<TType, TEvent, TResponse> : MonoBehaviour, IGameEventListener<TType>
        where TEvent : BaseGameEvent<TType>
        where TResponse : UnityEvent<TType>
    {
        protected ScriptableObject GameEvent { get { return _event; } }
        protected UnityEventBase Response { get { return _response; } }

        private TEvent _previouslyRegisteredEvent = default;
        [SerializeField]
        private TEvent _event = default;
        [SerializeField]
        private TResponse _response = default;

        void IGameEventListener<TType>.OnEventRaised(TType value)
        {
            RaiseResponse(value);
        }
        protected void RaiseResponse(TType value)
        {
            _response.Invoke(value);
        }
        private void OnEnable()
        {
            if (_event != null)
                Register();
        }
        private void OnDisable()
        {
            if (_event != null)
                _event.UnregisterListener(this);
        }
        private void Register()
        {
            if (_previouslyRegisteredEvent != null)
            {
                _previouslyRegisteredEvent.UnregisterListener(this);
            }

            _event.RegisterListener(this);
            _previouslyRegisteredEvent = _event;
        }
    }

    public abstract class BaseGameEventListener<TEvent, TResponse> : MonoBehaviour, IGameEventListener
    where TEvent : BaseGameEvent
    where TResponse : UnityEvent
    {
        protected ScriptableObject GameEvent { get { return _event; } }
        protected UnityEventBase Response { get { return _response; } }

        private TEvent _previouslyRegisteredEvent = default;
        [SerializeField]
        private TEvent _event = default;
        [SerializeField]
        private TResponse _response = default;

        void IGameEventListener.OnEventRaised()
        {
            RaiseResponse();
        }
        protected void RaiseResponse()
        {
            _response.Invoke();
        }
        private void OnEnable()
        {
            if (_event != null)
                Register();
        }
        private void OnDisable()
        {
            if (_event != null)
                _event.UnregisterListener(this);
        }
        private void Register()
        {
            if (_previouslyRegisteredEvent != null)
            {
                _previouslyRegisteredEvent.UnregisterListener(this);
            }

            _event.RegisterListener(this);
            _previouslyRegisteredEvent = _event;
        }
    }
}
