using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int playerScore;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    public Boolean isGameOver = false;
    public Boolean isPaused = false;

    [ContextMenu("updatePlayerScore")]
    public void updatePlayerScore(int increaseBy) { 
        if (isGameOver) return;
        playerScore += increaseBy;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() { 
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void endGame() { 
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }

    public void pauseGame() {
        Time.timeScale = 0;
        isPaused = true;
        pauseScreen.SetActive(true);
    }

    public void resumeGame() {
        Time.timeScale = 1;
        isPaused = false;
        pauseScreen.SetActive(false);
    }

    public void backToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

}
