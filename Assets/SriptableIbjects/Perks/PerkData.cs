using UnityEngine;

[CreateAssetMenu(fileName = "NewPerk", menuName = "PerkData", order = 52)]
public class PerkData : ScriptableObject
{
    [SerializeField]
    private string _perkName;
    [SerializeField]
    private string _description;
    [SerializeField]
    private uint _upgradeCost;
    [SerializeField]
    private uint _damage;
    [SerializeField]
    private ElementType _type;

    public string PerkName => _perkName;
    public string Description => _description;
    public uint UpgradeCost => _upgradeCost;
    public uint Damage => _damage;
    public ElementType Type => _type;
}
