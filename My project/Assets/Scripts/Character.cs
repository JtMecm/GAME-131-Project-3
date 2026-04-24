using System.Collections.Generic;
using UnityEngine;

// [CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : MonoBehaviour
{
    public string characterName;
    public string characterClass;

    public void AddToParty(PartyMember newMember)
    {

    }
}

[System.Serializable]
public class PartyMember
{
    public string name;
    public string characterClass;
    public Item rightHand;
    public Item leftHand;
    public Item body;
}