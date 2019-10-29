using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class MenuItemExamplesUtilities {

    [MenuItem("My Tools/Utilities/RandomizePositions")]
    public static void RandomizePositions() {
        foreach (GameObject g in Selection.gameObjects) {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);
            float y = 0;

            g.transform.position = new Vector3(x, y, z);

        }

        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }

}
