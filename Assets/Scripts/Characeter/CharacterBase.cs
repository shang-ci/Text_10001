using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected int _hp;
    [SerializeField] protected int _mp;

    [SerializeField] protected CardLibrarySO cardLibrarySO;//ÅÆ¿â

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int HP
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public int MP
    {
        get { return _mp; }
        set { _mp = value; }
    }


    public void TakDamge(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Debug.Log($"Name : {_name} TakeDamge : {damage} µã");
        }
    }
}
