using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
static class HierarchyEditor
{
    static HierarchyEditor()
    {
        Debug.Log("°ó¶¨  HierarchyWindowMethod");
        EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
    }
    static GUIStyle _style = new GUIStyle
    {
        //imagePosition = ImagePosition.ImageOnly,
        //padding = new RectOffset(2, 2, 2, 2),
        alignment = TextAnchor.MiddleRight,
        //fixedWidth = 20,
        //fixedHeight = 16,
        fontSize = 20,
    };

    static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
    {
        GameObject hierarchyObj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        if (hierarchyObj != null)
        {
            _style.normal.textColor = Color.green;
            EditorGUI.LabelField(selectionRect, "+", _style);
        }
    }

}
