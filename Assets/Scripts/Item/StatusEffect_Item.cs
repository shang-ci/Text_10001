using UnityEngine;

public abstract class StatusEffect_Item : Item
{
    //改变时机——在打出卡牌时触发状态效果的状态卡可以在此处改变时机
    public abstract void ChangeTime(CharacterBase character);
    public abstract void ExecuteEffect(CharacterBase from, CharacterBase target);
    public abstract void RemoveEffect(CharacterBase character);
}
