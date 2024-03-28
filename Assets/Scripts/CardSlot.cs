using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    public Hire SlottedHire;

    public bool isSlotted;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided");

        if (collision != null)
        {
            if (collision.CompareTag("Card"))
            {
                SlottedHire = collision.gameObject.GetComponentInChildren<Hire>();

                isSlotted = true;

                Debug.Log(" and is a card");
            }
            else
            {
                Debug.Log(" but not a card");
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (SlottedHire != null)
        {
            if (collision.CompareTag("Card"))
            {
                SlottedHire = null;

                isSlotted = false;

                Debug.Log("Slotted hire cleared!");
            }
        }
    }
}
