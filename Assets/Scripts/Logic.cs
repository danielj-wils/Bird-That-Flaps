using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public static Logic instance;

    public float playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    private void Awake() 
    {
        instance = this;
        gameOverScreen.SetActive(false);  // Start with the game over screen hidden
    }

    private void Update() 
    {    }

    [ContextMenu("Increase Score")]
    public void AddScore(float scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;  // Pause game
    }
}
