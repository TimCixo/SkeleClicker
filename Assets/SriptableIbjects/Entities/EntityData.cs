using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "EntityData ", order = 52)]
public class EntityData : ScriptableObject
{
    [SerializeField]
    private int _healPoint;
    [SerializeField]
    private Drop[] _dropList;
    [SerializeField]
    private ElementType _type;
    
    public int HealPoint => _healPoint;
    public Drop[] DropList => _dropList;
    public ElementType Type => _type;
}
