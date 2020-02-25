using UnityEngine;

namespace SOA
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "SOA_IntGameEvent.asset",
        menuName = SOA_Settings.GAME_EVENT + "int",
        order = SOA_Settings.ASSET_MENU_ORDER_EVENTS + 3)]
    public sealed class IntGameEvent : BaseGameEvent<int>
    {
    }
}