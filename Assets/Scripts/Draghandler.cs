using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform dragObject;
    public Vector2 offset;
    public bool isDragging = false;

    public CardSlot slot;

    private void Awake()
    {
        slot = FindObjectOfType<CardSlot>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 mousePosition = eventData.position;
        Vector2 objectPosition = dragObject.anchoredPosition;
        offset = mousePosition - objectPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mousePosition = eventData.position;
        dragObject.anchoredPosition = mousePosition - offset;

        isDragging = true;

    }
    public void OnEndDrag(PointerEventData eventData)
    {

        isDragging = false;

        if (slot.isSlotted == true)
        {
            gameObject.transform.position = slot.transform.position;
        }
    }
}
