using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _skeletons;

    private static Transform _spawner;

    private void Start()
    {
        _spawner = gameObject.transform.Find("spawner");

        SpawnSkeleton();
    }

    public void SpawnSkeleton()
    {
        GameObject skeleton = _skeletons[Random.Range(0, 3)];

        Instantiate(skeleton, _spawner);
    }
}
