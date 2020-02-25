using UnityEditor;
using UnityEngine;
using System.Reflection;
using Type = System.Type;

namespace SOA
{
    [CustomEditor(typeof(BaseGameEvent<>), true)]
    public class TypedGameEventDrawer : Editor
    {
        private MethodInfo _raiseMethod;

        void OnEnable()
        {
            _raiseMethod = target.GetType().BaseType.GetMethod("Raise", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        }
        private object GetDebugValue(SerializedProperty property)
        {
            Type targetType = property.serializedObject.targetObject.GetType();
            FieldInfo targetField = targetType.GetField("_debugValue", BindingFlags.Instance | BindingFlags.NonPublic);

            return targetField.GetValue(property.serializedObject.targetObject);
        }
        private void CallMethod(object value)
        {
            _raiseMethod.Invoke(target, new object[1] { value });
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            SerializedProperty property = serializedObject.FindProperty("_debugValue");

            if (GUILayout.Button("Raise"))
            {
                CallMethod(GetDebugValue(property));
            }
        }

    }


    [CustomEditor(typeof(BaseGameEvent), true)]
    public class GameEventDrawer : Editor
    {
        private GameEvent Target { get { return (GameEvent)target; } }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Raise"))
            {
                Target.Raise();
            }
        }
    }
}