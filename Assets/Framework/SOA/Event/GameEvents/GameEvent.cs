using UnityEngine;

namespace SOA
{
    [CreateAssetMenu(
        fileName = "GameEvent.asset",
        menuName = SOA_Settings.GAME_EVENT + "Game Event",
        order = SOA_Settings.ASSET_MENU_ORDER_EVENTS - 1)]
    public sealed class GameEvent : BaseGameEvent
    {
    }
}