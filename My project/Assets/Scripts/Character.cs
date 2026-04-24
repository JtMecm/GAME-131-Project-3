using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private List<PartyMember> party;

    public List<PartyMember> GetParty { get { return party; } }

    public void AddToParty(PartyMember newMember)
    {
        if (party.Contains(newMember))
        {
            Debug.LogError("They are already in your party!");
            return;
        }

        party.Add(newMember);
    }

    public void ClearParty()
    {
        party.Clear();
    }
}

[System.Serializable]
public class PartyMember
{
    public string name;
    public string characterClass;
    public int level;
    public Item rightHand;
    public Item leftHand;
    public Item body;
}