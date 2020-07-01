using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // [x] walk (speed)
    // [x] Spawn
    // [x] Destroy
    // [x] Colider

    public float speed;

    void Start() {}

    void Update()
    {
        Walk();
    }

    private void Walk()
    {
        float currentX = transform.position.x;
        float newX = currentX - 1 * speed * Time.deltaTime;
        transform.position = new Vector2(newX, transform.position.y);

        TryDestroy();
    }

    private void TryDestroy()
    {
        if (transform.position.y <= -6f) Destroy(this.gameObject);
    }
}
