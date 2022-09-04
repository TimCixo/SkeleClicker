using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "EntityData ", order = 52)]
public class EntityData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private ElementTypes _type;
    [SerializeField]
    private int _healPoints;
    [SerializeField]
    private uint _dropCount;
    [SerializeField]
    private GameObject _drop;

    public string Name => _name;
    public ElementTypes Type => _type;
    public int HealPoints => _healPoints;
    public uint DropCount => _dropCount;
    public GameObject Drop => _drop;
}
