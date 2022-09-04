using UnityEngine;

public class Skeleton : MonoBehaviour
{
    [SerializeField]
    private EntityData _data;

    private string _name;
    private IElement _type;
    private GameObject _drop;

    private int _healPoints;

    public IElement Type => _type;

    private void Start()
    {
        _name = _data.Name;
        _type = ElementController.GetElement(_data.Type);
        _drop = _data.Drop;
        _healPoints = _data.HealPoints;

        _drop.GetComponent<Drop>().IncreaseCount(_data.DropCount);
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
        GameObject spawner = GameObject.Find("Background");

        DropController.AddDrop(_drop);

        Destroy(gameObject);

        spawner.GetComponent<SceneController>().SpawnSkeleton();
    }
}