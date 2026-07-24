using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover triggered");
        SFXManager.instance.PlaySound(hoverSound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click triggered");
        SFXManager.instance.PlaySound(clickSound);
    }
}