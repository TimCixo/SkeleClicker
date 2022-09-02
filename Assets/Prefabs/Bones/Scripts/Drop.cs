using UnityEngine;

public class Drop : MonoBehaviour
{
    [SerializeField]
    private readonly string _name;
    [SerializeField]
    private readonly Sprite _icon;
    [SerializeField]
    private uint _count;

    public void IncreaseCount(uint count)
    { 
    }

    public bool TryDecreaseCount(uint count)
    {
        return false;
    }
}
