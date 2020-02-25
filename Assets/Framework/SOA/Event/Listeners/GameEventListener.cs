using UnityEngine;
using UnityEngine.Events;

namespace SOA
{
    [AddComponentMenu(SOA_Settings.EVENT_LISTENER_SUBMENU + "Game Event Listener")]
    public sealed class GameEventListener : BaseGameEventListener<GameEvent, UnityEvent>
    {
    }
}