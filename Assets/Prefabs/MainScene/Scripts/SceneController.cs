using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private static readonly GameObject[] _skeletons;

    private static Transform _spawner;

    private void Start()
    {
        _spawner = gameObject.transform.Find("spawner");
    }

    public static void SpawnSkeleton()
    {
        GameObject skeleton = _skeletons[Random.Range(0, 3)];

        Instantiate(skeleton, _spawner);
    }
}
