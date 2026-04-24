using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterWindow : EditorWindow
{
    private GUIStyle heading = new GUIStyle();
    private GUIContent content = new GUIContent();

    private List<PartyMember> party;
    private int partyIndex;
    private string nameText;
    private Class characterClass;
    private int characterLevel;
    private Item rightHand;
    private Item leftHand;
    private Item body;

    public List<PartyMember> GetParty { get { return party; } }

    private void OnEnable()
    {
        heading.alignment = TextAnchor.MiddleCenter;
        heading.fontStyle = FontStyle.Bold;

        content.text = "Items";
        content.tooltip = "Items";

        partyIndex = 0;

        nameText = "";
        characterClass = new Class();
        characterLevel = 1;
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

        EditorGUILayout.Space(5);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Class ");
        EditorGUILayout.Space();
        characterClass = (Class) EditorGUILayout.EnumPopup(characterClass, GUILayout.Width(300));
        EditorGUILayout.Space();
        GUILayout.Label("Level ");
        EditorGUILayout.Space();
        characterLevel = EditorGUILayout.IntField(characterLevel);
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(20);
        GUILayout.Label("Inventory");

        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.Label("Right Hand ");
        rightHand = (Item) EditorGUILayout.ObjectField(rightHand, typeof(Item), true);
        EditorGUILayout.Space(10);
        GUILayout.Label("Left Hand ");
        if (characterClass == Class.Survivor)
        {
            EditorGUILayout.HelpBox("Gnawed Off", MessageType.Warning, true);
        }
        else
        {
            leftHand = (Item) EditorGUILayout.ObjectField(leftHand, typeof(Item), true);
        }
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(10);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Body ");
        body = (Item) EditorGUILayout.ObjectField(body, typeof(Item), true);
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(20);

        if (GUILayout.Button("Add Party Member") && party.Count < 4)
        {
            foreach(PartyMember member in party)
            {
                if (member.name == nameText)
                {
                    Debug.LogError("They are already in your party!");
                    break;
                }
            }

            party.Add(new PartyMember());
            party[partyIndex].name = nameText;
            partyIndex++;
        }

        if (party.Count >= 4)
        {
            EditorGUILayout.HelpBox("Your party is full!", MessageType.Error, true);
        }

        if (GUILayout.Button("Clear Party"))
        {
            party = new List<PartyMember>();
            partyIndex = 0;
        }

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

    public void PopulateParty()
    {
        for (int i = 0; i < party.Count; i++)
        {

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