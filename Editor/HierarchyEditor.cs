
using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace EditorTools
{
    [InitializeOnLoad]
    static class HierarchyEditor
    {
        //("°ó¶¨  HierarchyWindowMethod");
        static HierarchyEditor()
        {
            EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
        }
        private static GUIStyle numStyle = null;
        const string style_name = "CN CountBadge";

        static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
        {
            GameObject hierarchyObj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
            if (hierarchyObj == null)
                return;
            if (numStyle == null)
            {
                numStyle = new GUIStyle()
                {
                    fixedHeight = EditorGUIUtility.singleLineHeight - 4,
                    fontSize = 10,
                    fontStyle = FontStyle.Bold,
                    normal = { textColor = new Color(0, 1, 1, 0.5f) },
                    padding = new RectOffset(1, 0, 0, 0),
                    alignment = TextAnchor.MiddleRight
                };
            }
            Camera camScript = hierarchyObj.GetComponent<Camera>();
            if (camScript != null)
            {
                selectionRect.x += 225;
                selectionRect.y += 1;
                selectionRect.width = 25f;
                //selectionRect.height = EditorGUIUtility.singleLineHeight - 4;
                GUI.Button(selectionRect, EditorGUIUtility.IconContent("Camera Icon"), numStyle);
                //EditorGUI.LabelField(selectionRect, "MCam", numStyle);
                selectionRect.x -= EditorGUIUtility.singleLineHeight;
                selectionRect.y -= 1;

            }
            Light lightScript = hierarchyObj.GetComponent<Light>();
            if (lightScript != null)
            {
                selectionRect.x += 225;
                selectionRect.width = 25f;
                //EditorGUI.LabelField(selectionRect, "Light", numStyle);
                GUI.Button(selectionRect, EditorGUIUtility.IconContent("Light Icon"), numStyle);
                selectionRect.x -= EditorGUIUtility.singleLineHeight;
                selectionRect.y -= 1;
            }
        }
    }
    public class TestOtherLoad
    {
        public void LogError(string message)
        {
            Debug.LogError(message);
        }
    }
}
