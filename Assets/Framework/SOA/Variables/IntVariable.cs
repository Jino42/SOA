
namespace SOA
{
    using UnityEngine;

    [CreateAssetMenu(
        fileName = "IntVariable.asset",
        menuName = SOA_Settings.VARIABLE_SUBMENU + "int",
        order = SOA_Settings.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class IntVariable : BaseVariable<int>
    {
    }
}
