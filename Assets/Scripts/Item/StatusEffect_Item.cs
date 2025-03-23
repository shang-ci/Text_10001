using UnityEngine;

public abstract class StatusEffect_Item : Item
{
    //�ı�ʱ�������ڴ������ʱ����״̬Ч����״̬�������ڴ˴��ı�ʱ��
    public abstract void ChangeTime(CharacterBase character);
    public abstract void ExecuteEffect(CharacterBase from, CharacterBase target);
    public abstract void RemoveEffect(CharacterBase character);
}
