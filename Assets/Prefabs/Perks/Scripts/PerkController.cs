using UnityEngine;

public class PerkController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _perks;

    public static GameObject[] Perks;

    private void Start()
    {
        Perks = _perks;
    }
}
