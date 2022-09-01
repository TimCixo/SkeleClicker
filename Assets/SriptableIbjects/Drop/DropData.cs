using UnityEngine;

[CreateAssetMenu(fileName = "NewDrop", menuName = "DropData", order = 52)]
public class DropData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private Sprite _icon;

    public string Name => _name;
    public Sprite Icon => _icon;
}
