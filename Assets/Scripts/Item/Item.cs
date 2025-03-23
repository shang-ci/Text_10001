using Unity.VisualScripting;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField] protected string itemName;
    [TextArea(15, 20)]
    [SerializeField] protected string description;
    [SerializeField] protected Sprite icon;
    [SerializeField] protected int id;
    [SerializeField] protected ItemType type;

    public Sprite Icon
    {
        get { return icon; }
        set { icon = value; }
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public ItemType Type
    {
        get { return type; }
        set { type = value; }
    }
}
