using UnityEngine;
using UnityEngine.EventSystems;

public class OnPerkClickHandler : MonoBehaviour
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Perk perk = GetComponent<Perk>();

        perk.TryUpgrade();
    }
}
