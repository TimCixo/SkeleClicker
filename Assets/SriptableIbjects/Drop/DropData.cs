using UnityEngine;

[CreateAssetMenu(fileName = "NewDrop", menuName = "DropData", order = 52)]
public class DropData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;

    public string Name => _name;
    public string Description => _description;
}
