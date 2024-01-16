using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public List<Transform> SpawnPoints;
    public GameObject cardPrefab;
    private int totalSpawnedCards = 0;  // Variable to keep track of the total spawned cards
    private bool canSpawn = true;  // Variable to control spawning

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            SpawnCards();
        }
    }

    public List<Card> SpawnCards()
    {
        var cards = new List<Card>();

        foreach (var spawnPoint in SpawnPoints)
        {
            if (totalSpawnedCards >= 8)
            {
                Debug.Log("Card limit reached. Cannot spawn new cards");
                canSpawn = false;  // Set to false to prevent further spawning
                break;  // Exit loop if the limit is reached
            }

            // Creates new card object which has the hires

            // Insert SoundFX here

            GameObject cardObject = Instantiate(cardPrefab, spawnPoint.position, Quaternion.identity);

            Card cardComponent = cardObject.GetComponent<Card>();

            // Checks to make sure the card is valid before adding to list.
            if (cardComponent != null)
            {
                cards.Add(cardComponent);
                totalSpawnedCards++;  // Increment the total spawned cards
            }
        }

        return cards;
    }
}