using UnityEngine;

[CreateAssetMenu(fileName = "NewPerk", menuName = "PerkData", order = 52)]
public class PerkData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private GameObject _upgradeDrop;
    [SerializeField]
    private uint _upgradeCost;
    [SerializeField]
    private uint _damage;
    [SerializeField]
    private ElementTypes _type;

    public string Name => _name;
    public string Description => _description;
    public GameObject UpgradeDrop => _upgradeDrop;
    public uint UpgradeCost => _upgradeCost;
    public uint Damage => _damage;
    public ElementTypes Type => _type;
}
