using UnityEngine;

public class Perk : MonoBehaviour
{
    [SerializeField]
    private readonly string _name;
    [SerializeField]
    private readonly Sprite _icon;
    [SerializeField]
    private readonly uint _damage;

    [SerializeField]
    private uint _level;
    [SerializeField]
    private uint _upgradeCost;

    public uint GetDamage(ElementType elementType)
    {
        return 0;
    }

    public bool TryUpgrade()
    { 
        return false;
    }
}
