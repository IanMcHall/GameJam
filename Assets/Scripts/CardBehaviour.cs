using System.Collections.Generic;
using UnityEngine;

public class CardBehaviour : MonoBehaviour
{
    public GameObject selectedObject;
    private Vector3 offset;

    // Store the original position of the card
    private Vector3 originalPosition;

    void Start()
    {
        // Store the original position when the script starts
        originalPosition = transform.position;
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //checks if overlapping an object and allows you to click to drag taking the mouse position in to consideration
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject && targetObject.CompareTag("Card"))
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }

        //keeps the transform and offset so that it moves with the mouse based on where you clicked the sprite
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }

        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            // Check if the card is overlapping a "slot"
            Collider2D[] overlappingSlots = Physics2D.OverlapCircleAll(selectedObject.transform.position, 0.5f);

            foreach (Collider2D slotCollider in overlappingSlots)
            {
                if (slotCollider.CompareTag("Slot"))
                {
                    // Snap to the slot's position
                    selectedObject.transform.position = slotCollider.transform.position;

                    Debug.Log("Card snapped to slot!");
                }
            }

            selectedObject = null;
        }
    }
}
