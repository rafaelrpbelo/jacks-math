using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsController : MonoBehaviour
{
    public int maxAmount = 3;
    public GameObject heart;
    public float spaceBetweenHeats = 1f;

    private int remaining;
    private float spawnOffset = 0;
    private GameObject[] hearts;
    private List<GameObject> heartList = new List<GameObject>();

    void Start()
    {
        remaining = maxAmount;
        SpawnHearts();
    }

    void Update()
    {
        
    }

    public int DecreaseHeart(int amount = 1) {
        if (remaining > 0) {
            remaining--; 
            heartList[remaining].SendMessage("GetLost");
        }

        return remaining;
    }

    private void SpawnHearts() {
        for(int i = 0; i < maxAmount; i++) {
            var newHeart = Instantiate(heart, new Vector3(transform.position.x + spawnOffset, transform.position.y, 0), transform.rotation);
            spawnOffset += spaceBetweenHeats;
            heartList.Add(newHeart);
        }
    }
}
