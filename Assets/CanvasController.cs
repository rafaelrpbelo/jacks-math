using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{   
    public GameObject score;

    private Text scoreText;
    private int scoreAmount;

    void Start()
    {
        scoreText = score.GetComponent<Text>();
    }

    void FixedUpdate()
    {
        scoreAmount++;
        UpdateScore(scoreAmount);
    }

    public void UpdateScore(int amount) {
        scoreText.text = amount.ToString();
    }
}
