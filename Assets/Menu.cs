using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public TMP_Text outputText;
    public Button startButton;

    private void Start()
    {
        // Add a listener to the start button to call the StartGame method when clicked
        startButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        // Retrieve the player name from the InputField
        string playerName = playerNameInput.text;

        // Check if the player name is not empty
        if (!string.IsNullOrEmpty(playerName))
        {
            // Save the player name to PlayerPrefs
            PlayerPrefs.SetString("PlayerName", playerName);

            // Load the "Level1" scene
            SceneManager.LoadScene("Level1");
        }
        else
        {
            // Display an error message if the player name is empty
            outputText.text = "Please enter your name!";
        }
    }
}