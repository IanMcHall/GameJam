using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardSnap : MonoBehaviour
{
    public GameObject selectedObject;
    Vector3 offset;

    public static List<Hire> JobHires;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Slot"))
        {
            Debug.Log("Card detected!");

            Hire? hire;

            hire = collision.gameObject.GetComponent<Hire>();

            JobHires.Add(hire);

        }
    }

}
