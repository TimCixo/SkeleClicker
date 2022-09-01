using UnityEngine;

public class Skeleton : MonoBehaviour
{
    [SerializeField]
    private readonly string _name;
    [SerializeField]
    private readonly ElementType _type;
    [SerializeField]
    private readonly GameObject[] _dropTable;

    [SerializeField]
    private int _healPoints;

    public void TakeDamage(uint damage)
    {
    }

    private void Die()
    { 
    }
}