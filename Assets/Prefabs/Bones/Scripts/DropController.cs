using UnityEngine;

public static class DropController
{
    [SerializeField]
    public static readonly GameObject[] DropList;

    public static void AddDrop(GameObject[] dropList)
    {
        foreach (GameObject i in DropList)
        {
            foreach (GameObject j in dropList)
            {
                Drop ownDrop = i.GetComponent<Drop>();
                Drop otherDrop = j.GetComponent<Drop>();

                if (ownDrop.Name == otherDrop.Name)
                {
                    ownDrop.IncreaseCount(otherDrop.Count);
                }
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
