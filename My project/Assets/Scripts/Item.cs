using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public GameObject prefab;
    public Type itemType;
}

public enum Type
{
    Weapon,
    Gear,
    Consumable,
    Key
}