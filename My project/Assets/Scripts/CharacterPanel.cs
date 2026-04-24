using TMPro;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI classText;
    [SerializeField] private int level;
    [SerializeField] private TextMeshProUGUI rightHandText;
    [SerializeField] private TextMeshProUGUI leftHandText;

    private void Awake()
    {
        
    }

    public void InstantiatePanel(PartyMember memberToAdd)
    {
        
    }

    public CharacterPanel(string name, string classs, int lvl)
    {
        nameText.text = name;
        classText.text = classs + lvl.ToString();
    }
}
