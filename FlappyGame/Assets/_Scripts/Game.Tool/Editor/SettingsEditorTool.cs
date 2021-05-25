using UnityEngine;
using UnityEditor;
using Zenject;

namespace Game.Tool
{
    public class SettingsEditorTool : EditorWindow
    {
        [MenuItem("Tools/FlappyGameTools/Settings")]
        private static void Open()
        {
            GetWindow(typeof(SettingsEditorTool));
        }

        private void OnGUI()
        {
            GUILayout.Label("Settings", EditorStyles.boldLabel);
            var assets = AssetDatabase.FindAssets("Settings", new[] { "Assets/_Settings" });
            foreach (var guid in assets)
            {
                var clip = AssetDatabase.LoadAssetAtPath<ScriptableObjectInstaller>(AssetDatabase.GUIDToAssetPath(guid));
                GUILayout.Label(clip.GetType().ToString(), EditorStyles.boldLabel);
                Editor.CreateEditor(clip).OnInspectorGUI();
            }
        }
    }
}