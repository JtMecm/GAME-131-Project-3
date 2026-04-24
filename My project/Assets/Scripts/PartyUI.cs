using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartyUI : MonoBehaviour
{
    [SerializeField] private GameObject panelPrefab;
    private GameObject charPanel;

    private void AddPartyMemberToCanvas(PartyMember newMember)
    {
        charPanel = Instantiate(panelPrefab, this.transform);
    }
}
