using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Skeleton skeleton = gameObject.GetComponent<Skeleton>();

        skeleton.TakeDamage(GetDamage(skeleton.Type));
    }

    private uint GetDamage(IElement elementType)
    {
        uint totalDamage = 0;

        foreach(GameObject i in PerkController.Perks)
        {
            Perk perk = i.GetComponent<Perk>();

            totalDamage += perk.GetDamage(elementType);
        }

        return totalDamage;
    }
}
