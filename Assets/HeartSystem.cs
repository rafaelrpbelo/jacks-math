using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private int remainingHearts;

    void Start() {
        remainingHearts = hearts.Length;
    }

    void Update()
    {
        if (remainingHearts < 1) Die(); 
    }

    public void TakeDamage(int damage) {
        if (remainingHearts < 1) return;

        remainingHearts -= damage;
        hearts[remainingHearts].sprite = emptyHeart;
    }

    private void Die () {
        Time.timeScale = 0;
    }
}
