using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextSceneUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        // Subscribe to the ScoreChanged event
        ScoreManager.ScoreChanged += UpdateScoreText;
    }

    private void OnDisable()
    {
        // Unsubscribe from the ScoreChanged event to prevent memory leaks
        ScoreManager.ScoreChanged -= UpdateScoreText;
    }

    // Method to update the score text
    private void UpdateScoreText(int newScore)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + newScore;
        }
    }
}