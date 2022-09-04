using UnityEngine;

public class DropController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _dropList;

    public static GameObject[] DropList;

    private void Start()
    {
        DropList = _dropList;
    }

    public static void AddDrop(GameObject drop)
    {
        Drop otherDrop = drop.GetComponent<Drop>();

        foreach (GameObject i in DropList)
        {
            Drop ownDrop = i.GetComponent<Drop>();

            if (ownDrop.Name == otherDrop.Name)
            {
                ownDrop.IncreaseCount(otherDrop.Count);
            }
        }
    }

    public static bool TryDecreaseCount(string dropName, uint count)
    {
        foreach (GameObject i in DropList)
        {
            Drop drop = i.GetComponent<Drop>();

            if (drop.Name == dropName)
            {
                return drop.TryDecreaseCount(count);
            }
        }

        return false;
    }

    public static uint GetCount(string dropName)
    {
        foreach (GameObject i in DropList)
        {
            Drop drop = i.GetComponent<Drop>();

            if (drop.Name == dropName)
            {
                return drop.Count;
            }
        }

        return 0;
    }
}
