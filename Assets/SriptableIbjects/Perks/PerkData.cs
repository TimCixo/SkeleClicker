using UnityEngine;

[CreateAssetMenu(fileName = "NewPerk", menuName = "PerkData", order = 52)]
public class PerkData : ScriptableObject
{
    [SerializeField]
    private string _perkName;
    [SerializeField]
    private uint _upgradeCost;
    [SerializeField]
    private uint _damage;
    [SerializeField]
    private Sprite _icon;

    public string PerkName => _perkName;
    public uint UpgradeCost => _upgradeCost;
    public uint Damage => _damage;
    public Sprite Icon => _icon;
}
