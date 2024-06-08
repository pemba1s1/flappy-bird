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
    public Boolean isGameOver = false;

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

}
