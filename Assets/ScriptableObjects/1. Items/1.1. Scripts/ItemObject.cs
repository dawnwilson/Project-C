using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public Sprite icon;
    public ItemType type;
    [TextArea(15,20)]
    public string description;
}
