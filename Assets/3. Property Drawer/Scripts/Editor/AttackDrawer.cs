using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Attack))]
public class AttackDrawer : PropertyDrawer {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);

        //Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        //Don't make child fields be indented
        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        //Calculate rects
        int nameLabelWidth = 40;
        Rect nameLabel = new Rect(position.x, position.y, nameLabelWidth, position.height);
        int nameRectWidth = 100;
        int nameRectOffset = nameLabelWidth + 5;
        Rect nameRect = new Rect(position.x + nameRectOffset, position.y, nameRectWidth, position.height);
        int rangeLabelWidth = 40;
        int rangeLabelOffset = nameRectOffset + nameRectWidth + 5;
        Rect rangeLabel = new Rect(position.x + rangeLabelOffset, position.y, rangeLabelWidth, position.height);
        int rangeRectWidth = 50;
        int rangeRectOfset = rangeLabelWidth + rangeLabelOffset + 5;
        Rect rangeRect = new Rect(position.x + rangeRectOfset, position.y, rangeRectWidth, position.height);
        float strengthRectOffset = rangeRectOfset + rangeRectWidth + 5;
        float strengthRectWidth = position.width - strengthRectOffset;
        Rect strengthRect = new Rect(position.x + strengthRectOffset, position.y, strengthRectWidth, position.height);

        //Draw fields
        EditorGUI.LabelField(nameLabel, "Name");
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);
        EditorGUI.LabelField(rangeLabel, "Range");
        EditorGUI.PropertyField(rangeRect, property.FindPropertyRelative("range"), GUIContent.none);
        EditorGUI.PropertyField(strengthRect, property.FindPropertyRelative("strength"), GUIContent.none);

        //Set indent level
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();

    }
}
