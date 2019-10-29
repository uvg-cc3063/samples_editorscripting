using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class WaypointLoader : EditorWindow {
    private string filename = "Track";
    private int laneId = 1;
    private GameObject prefab;
    private GameObject parent;

    [MenuItem("My Windows/Waypoint Loader")]
    public static void Init() {
        WaypointLoader window = GetWindow<WaypointLoader>(false, "Waypoint Loader", true);
        window.Show();
    }

    private void OnGUI() {
        laneId = EditorGUILayout.IntField("Lane", laneId);
        prefab = (GameObject)EditorGUILayout.ObjectField("Waypoint Prefab", prefab, typeof(GameObject), true);
        parent = (GameObject)EditorGUILayout.ObjectField("Lane Parent", parent, typeof(GameObject), true);

        if (GUILayout.Button("Load")) {
            string filename = Application.dataPath + "/5. Editor Window/Data/" + this.filename + "_" + laneId + ".txt";

            using (StreamReader reader = new StreamReader(filename)) {
                int i = 0;
                while (reader.Peek() >= 0) {
                    string line = reader.ReadLine();
                    try {
                        string[] vectors = line.Split(';');
                        string[] position = vectors[0].Split(',');
                        string[] rotation = vectors[1].Split(',');

                        Vector3 positionVector = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
                        Vector3 rotationVector = new Vector3(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]));

                        GameObject newWaypoint = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                        newWaypoint.name = "Waypoint_" + i;
                        newWaypoint.transform.parent = parent.transform;
                        newWaypoint.transform.position = positionVector;
                        newWaypoint.transform.eulerAngles = rotationVector;

                    } catch (Exception e) {
                        Debug.Log(e.Message);
                    }
                    i++;
                }
            }

        }
    }
}
