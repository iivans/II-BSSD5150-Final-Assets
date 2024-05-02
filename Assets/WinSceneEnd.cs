using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinSceneEnd : MonoBehaviour
{
    public TMP_Text endText;

    private void Start()
    {
        // Retrieve the player name from PlayerPrefs
        string playerName = PlayerPrefs.GetString("PlayerName");

        // Check if the player name is not empty
        if (!string.IsNullOrEmpty(playerName))
        {
            // Display the player's name in the end text
            endText.text = "Congratulations, " + playerName + "! You completed the game!";
        }
        else
        {
            // If player name is not found, display a default message
            endText.text = "Congratulations! You completed the game!";
        }
    }
}