using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public List<Transform> SpawnPoints;
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCards();
        }   
    }

    public List<Card> SpawnCards()
    {
        var cards = new List<Card>();

       foreach (var spawnPoint in  SpawnPoints)
        {
            GameObject cardObject = Instantiate(cardPrefab, spawnPoint.position, Quaternion.identity);
            Card cardComponent = cardObject.GetComponent<Card>();

            if (cardComponent != null)
            {
                cards.Add(cardComponent);
            }
        }

        return cards; 
    }
}
