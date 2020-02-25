using UnityEngine;

namespace SOA
{
    [CreateAssetMenu(
        fileName = "SOA_GameObjectCollection.asset",
        menuName = SOA_Settings.COLLECTION_SUBMENU + "GameObject",
        order = SOA_Settings.ASSET_MENU_ORDER_COLLECTIONS + 0)]
    public class SetGameObject : Set<GameObject>
    {
    }
}
