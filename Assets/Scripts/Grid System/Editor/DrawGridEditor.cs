using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DrawGrid))]
public class DrawGridEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        DrawGrid baseClass = target as DrawGrid;

        if (GUILayout.Button("Navigate to Grid Settings"))
        {
            ProjectWindowUtil.ShowCreatedAsset(baseClass.gridSystem);
        }
    }
}