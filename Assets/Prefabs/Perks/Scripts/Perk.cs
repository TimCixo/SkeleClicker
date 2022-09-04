using UnityEngine;

public class Perk : MonoBehaviour
{
    [SerializeField]
    private PerkData _data;
    [SerializeField]
    private GameObject _upgradeDrop;

    private string _name;
    private string _description;
    private uint _upgradeCost;
    private uint _damage;
    private IElement _type;

    private uint _level = 1;
    private float _index = 1.5f;

    private void Start()
    {
        _name = _data.Name;
        _description = _data.Description;
        _upgradeDrop = _data.UpgradeDrop;
        _upgradeCost = _data.UpgradeCost;
        _damage = _data.Damage;
        _type = ElementController.GetElement(_data.Type);
    }

    public uint GetDamage(IElement elementType)
    {
        return (uint)(_type.GetIndex(elementType) * _damage * _level);
    }

    public bool TryUpgrade()
    {
        string upgradeDropName = _upgradeDrop.GetComponent<Drop>().Name;

        if (DropController.TryDecreaseCount(upgradeDropName, _upgradeCost))
        {
            _level++;
            _upgradeCost = (uint)(_upgradeCost * _index);

            return true;
        }
        else
        {
            return false;
        }
    }
}
