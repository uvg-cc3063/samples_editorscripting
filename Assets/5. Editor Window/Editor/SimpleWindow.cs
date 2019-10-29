using UnityEditor;
using UnityEngine;

public class SimpleWindow : EditorWindow {
    private string name = "";

    [MenuItem("My Windows/Simple Window")]
    public static void Init() {
        SimpleWindow window = GetWindow<SimpleWindow>(false, "Simple Window", true);
        window.Show();
    }

    private void OnGUI() {
        name = EditorGUILayout.TextField("Name", name);

        if (GUILayout.Button("Action")) {
            Debug.Log("Hello " + name);
        }
    }
}
