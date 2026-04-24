using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterWindow : EditorWindow
{
    private bool showInventory = true;
    private bool showAbility = true;

    private GUIStyle heading = new GUIStyle();
    private GUIContent content = new GUIContent();
    private Rect rect = new Rect(0, 0, 0, 0);
    private Rect area = new Rect(10, 10, 100, 100);

    private string nameText;
    private Class characterClass;

    private float bleat = 0f;
    private float baa = 100f;
    private string yip;

    private void OnEnable()
    {
        heading.alignment = TextAnchor.MiddleCenter;
        heading.fontStyle = FontStyle.Bold;

        content.text = "Items";
        content.tooltip = "Items";

        characterClass = new Class();

        yip = "Yip!";
    }

    [MenuItem("Window/Character Window")]
    private static void ShowWindow()
    {
        var window = GetWindow<CharacterWindow>();
        window.titleContent = new GUIContent("Character Window");

        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Character");

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Name");
        EditorGUILayout.Space();
        nameText = GUILayout.TextField(nameText, 20, GUILayout.Width(100));
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();
        
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Class");
        EditorGUILayout.Space();
        characterClass = (Class) EditorGUILayout.EnumPopup(characterClass, GUILayout.Width(300));
        EditorGUILayout.Space();
        EditorGUILayout.EndHorizontal();

        switch (characterClass)
        {
            case Class.Survivor:
                nameText = "Sam";
                break;
            case Class.Dancer:
                nameText = "Harriet";
                break;
            case Class.Unraveled:
                nameText = "Spine";
                break;
            default:
                break;
        }
    }

    public enum Class
    {
        None,
        Survivor,
        Dancer,
        Unraveled
    }
}