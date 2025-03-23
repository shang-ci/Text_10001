using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New DamageEffect_Item", menuName = "Item/Effect_Item/DamageEffect_Item")]
public class DamageEffect_Item : Effect_Item
{
    public override void Execute(CharacterBase from, CharacterBase target)
    {
        target.TakDamge(value);
    }

    //多目标重载
    public override void Execute(CharacterBase from, List<CharacterBase> targets)
    {
        
    }
}
