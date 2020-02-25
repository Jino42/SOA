

namespace SOA
{
    using UnityEngine;

    [CreateAssetMenu(
        fileName = "FloatVariable.asset",
        menuName = SOA_Settings.VARIABLE_SUBMENU + "float",
        order = SOA_Settings.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class FloatVariable : BaseVariable<float>
    {
    }
}
