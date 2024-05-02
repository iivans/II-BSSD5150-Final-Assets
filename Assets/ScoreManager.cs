using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    // Singleton instance
    public static ScoreManager Instance;

    // Score variable
    private int score;

    // Expose the score value through a public property
    public int Score => score;

    // Event triggered when the score changes
    public delegate void OnScoreChange(int newScore);
    public static event OnScoreChange ScoreChanged;

    // TMP text to display score
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        // Check if an instance already exists
        if (Instance == null)
        {
            // If not, set this instance as the singleton
            Instance = this;

            // Load the score from Player Preferences
            LoadScore();

            // Make this GameObject persist between scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this GameObject
            Destroy(gameObject);
        }
    }

    // Method to update the score
    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        // Trigger the ScoreChanged event
        ScoreChanged?.Invoke(score);
    }

    // Method to update the score text
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Method to save the score to Player Preferences
    private void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }

    // Method to load the score from Player Preferences
    private void LoadScore()
    {
        score = PlayerPrefs.GetInt("Score", 0);
    }

    // Method to reset the score (optional)
    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
        SaveScore();
    }
}