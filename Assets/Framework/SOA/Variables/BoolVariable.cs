
namespace SOA
{
    using UnityEngine;

    [CreateAssetMenu(
        fileName = "BoolVariable.asset",
        menuName = SOA_Settings.VARIABLE_SUBMENU + "bool",
        order = SOA_Settings.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class BoolVariable : BaseVariable<bool>
    {
    }
}
