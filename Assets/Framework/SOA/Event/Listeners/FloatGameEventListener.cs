using UnityEngine;
using UnityEngine.Events;

namespace SOA
{
    [AddComponentMenu(SOA_Settings.EVENT_LISTENER_SUBMENU + "float Event Listener")]
    public sealed class FloatGameEventListener : BaseGameEventListener<float, FloatGameEvent, UnityEvent<float>>
    {
    }
}