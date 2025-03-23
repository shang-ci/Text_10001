using UnityEngine;

public enum EffectTarget//决定效果的目标——
{
    Self,//自身
    Target,//单体目标

    TargetArea,//群体目标
    Random,//随机目标
    All,//所有目标
}

public enum ItemType
{
    Card,
    Equipment,
}