using UnityEngine;

public class Skeleton : MonoBehaviour
{
    [SerializeField]
    private EntityData _data;

    private string _name;
    private IElement _type;
    private GameObject[] _dropList;

    private int _healPoints;

    public IElement Type => _type;

    private void Start()
    {
        _name = _data.Name;
        _type = _data.Type;
        _dropList = _data.DropList;
        _healPoints = _data.HealPoints;
    }

    public void TakeDamage(uint damage)
    {
        _healPoints -= (int)damage;

        if (_healPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        DropController.AddDrop(_dropList);

        Destroy(gameObject);

        SceneController.SpawnSkeleton();
    }
}