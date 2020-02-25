
namespace SOA
{
    public static class SOA_Settings
    {
        public const int ASSET_MENU_ORDER_VARIABLES = 131;
        public const int ASSET_MENU_ORDER_EVENTS = 132;
        public const int ASSET_MENU_ORDER_COLLECTIONS = 133;

        public const string VARIABLE_SUBMENU = "SOA_Variables/";
        public const string COLLECTION_SUBMENU = "SOA_Sets/";
        public const string GAME_EVENT = "SOA_GameEvents/";

        public const string ADVANCED_GAME_EVENT = GAME_EVENT + "Advanced/";
        public const string ADVANCED_VARIABLE_SUBMENU = VARIABLE_SUBMENU + "Advanced/";
        public const string ADVANCED_VARIABLE_COLLECTION = COLLECTION_SUBMENU + "Advanced/";

        // Add Component Menus
        public const string ADD_COMPONENT_ROOT_MENU = "SOA/";
        public const string EVENT_LISTENER_SUBMENU = ADD_COMPONENT_ROOT_MENU + "EventListeners/";
    }
}