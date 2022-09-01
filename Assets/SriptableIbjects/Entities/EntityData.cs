using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "EntityData ", order = 52)]
public class EntityData : ScriptableObject
{
    [SerializeField]
    private int _healPoint;
    [SerializeField]
    private string _dropList;
    [SerializeField]
    private Sprite _entitySprite;
    
    public int HealPoint => _healPoint;
    public string DropList => _dropList;
    public Sprite EntitySprite => _entitySprite;
}
