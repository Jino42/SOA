using UnityEngine;
using UnityEngine.Events;

namespace SOA
{
    [AddComponentMenu(SOA_Settings.EVENT_LISTENER_SUBMENU + "int Event Listener")]
    public sealed class IntGameEventListener : BaseGameEventListener<int, IntGameEvent, UnityEvent<int>>
    {
    }
}