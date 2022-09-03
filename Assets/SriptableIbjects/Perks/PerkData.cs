using UnityEngine;

[CreateAssetMenu(fileName = "NewPerk", menuName = "PerkData", order = 52)]
public class PerkData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private string _upgradeDrop;
    [SerializeField]
    private uint _upgradeCost;
    [SerializeField]
    private uint _damage;
    [SerializeField]
    private IElement _type;

    public string Name => _name;
    public string Description => _description;
    public string UpgradeDrop => _upgradeDrop;
    public uint UpgradeCost => _upgradeCost;
    public uint Damage => _damage;
    public IElement Type => _type;
}
