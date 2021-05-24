using UnityEngine;
using UnityEditor;
using Zenject;

namespace Game.Tool
{
    public class EditPipesEditorTool : EditorWindow
    {
        [MenuItem("Tools/FlappyGameTools/EditCurrentPipes")]
        private static void Open()
        {
            GetWindow(typeof(EditPipesEditorTool));
        }

        private void OnGUI()
        {
            GUILayout.Label("Edit current pipes", EditorStyles.boldLabel);
            var assets = AssetDatabase.FindAssets("", new[] { "Assets/_Data/Pipes" });
            foreach (var guid in assets)
            {
                var clip = AssetDatabase.LoadAssetAtPath<ScriptableObject>(AssetDatabase.GUIDToAssetPath(guid));
                GUILayout.Label(clip.GetType().ToString(), EditorStyles.boldLabel);
                Editor.CreateEditor(clip).OnInspectorGUI();
            }
        }
    }
}