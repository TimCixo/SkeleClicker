using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "EntityData ", order = 52)]
public class EntityData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private IElement _type;
    [SerializeField]
    private int _healPoints;
    [SerializeField]
    private GameObject[] _dropList;

    public string Name => _name;
    public IElement Type => _type;
    public int HealPoints => _healPoints;
    public GameObject[] DropList => _dropList;
}
