using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScenarioController : MonoBehaviour
{
    private Vector2 startPosition;
    private float lenght;
    public float speed;

    public float resetPositionIn;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float currentX = transform.position.x;

        if (resetPositionIn >= currentX) {
            transform.position = startPosition;
        }
        else
        {
            float newX = (1 * speed * Time.deltaTime);
            transform.position = new Vector2(currentX - newX, transform.position.y);
        }
    }
}
