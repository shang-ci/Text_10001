using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect_Item : Item
{
    [SerializeField] protected EffectTarget targetType;//用来选择目标
    [SerializeField] protected int value;

    public EffectTarget TargetType
    {
        get { return targetType; }
        set { targetType = value; }
    }
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }


    public abstract void Execute(CharacterBase from, CharacterBase target);
    public abstract void Execute(CharacterBase from, List<CharacterBase> targets);

    public virtual void Initialize(int value, EffectTarget targetType)
    {
        this.value = value;
        this.targetType  = targetType;
    }
}
