using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Item", menuName = "Item/Card_Item")]
public class Card_item : Item
{
    [SerializeField] private int cost;
    [SerializeField] private List<Effect_Item> effects;//按理说最多是一个effect加一个statuseffect
    [SerializeField] private List<StatusEffect_Item> statusEffects;

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    public List<Effect_Item> Effects 
    {
        get { return effects; }
        set { effects = value; }
    }
    public List<StatusEffect_Item> StatusEffects
    {
        get { return statusEffects; }
        set { statusEffects = value; }
    }

    public void Initialize(string name, int id,int cost, Sprite image, string description, List<Effect_Item> effects, List<StatusEffect_Item> statusEffects)
    {
        ID = id;
        ItemName = name;
        Icon = image;
        Cost = cost;
        Description = description;
        Effects = effects;
        StatusEffects = statusEffects;
    }
}
