using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Value of the coin
    public int coinValue = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Get the ScoreManager instance
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (scoreManager != null)
            {
                // Update the score
                scoreManager.UpdateScore(coinValue);
            }

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}