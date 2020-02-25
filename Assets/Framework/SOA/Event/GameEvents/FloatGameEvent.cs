using UnityEngine;

namespace SOA
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "SOA_FloatGameEvent.asset",
        menuName = SOA_Settings.GAME_EVENT + "float",
        order = SOA_Settings.ASSET_MENU_ORDER_EVENTS + 3)]
    public sealed class FloatGameEvent : BaseGameEvent<float>
    {
    }
}