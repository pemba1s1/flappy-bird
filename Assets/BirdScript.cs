using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidBody2d;
    public int upForce;
    private logicScript logicScript;
    private audioManager audioManager;
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logicScript.isGameOver) return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (logicScript.isPaused)
            {
                logicScript.resumeGame();
            }
            else
            {
                logicScript.pauseGame();
            }
        }
        if (logicScript.isPaused) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody2d.velocity = Vector2.up * upForce;
            audioManager.PlaySFX(audioManager.flap);
        }
        if (rigidBody2d.transform.position.y >= 17 || rigidBody2d.transform.position.y <= -14)
        {
            logicScript.endGame();
            audioManager.PlaySFX(audioManager.gameOver);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logicScript.isGameOver) return;
        StartCoroutine(audioManager.PlaySequentially(audioManager.hit, audioManager.gameOver));
        logicScript.endGame();
    }
}
