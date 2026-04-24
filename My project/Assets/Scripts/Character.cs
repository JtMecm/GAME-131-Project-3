using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    [Header("Details")]
    public string characterName;
    public string characterClass;

    [Header("Attributes")]
    public int uses;
    public float effectiveness;
    public float failure;

    [Header("Inventory")]
    public List<string> items;

    [Header("Skills")]
    public List<string> skills;


    private void Awake()
    {
        
    }
}
