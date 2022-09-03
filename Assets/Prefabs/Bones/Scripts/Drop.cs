using UnityEngine;

public class Drop : MonoBehaviour
{
    [SerializeField]
    private DropData _data;
    [SerializeField]
    private uint _count;

    private string _name;
    private string _description;

    public uint Count => _count;
    public string Name => _name;

    private void Start()
    {
        _name = _data.Name;
        _description = _data.Description;
    }

    public void IncreaseCount(uint count)
    {
        _count += count;
    }

    public bool TryDecreaseCount(uint count)
    {
        if (count < _count)
        {
            _count -= count;

            return true;
        }
        else
        {
            return false;
        }
    }
}
