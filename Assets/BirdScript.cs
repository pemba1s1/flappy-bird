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
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !logicScript.isGameOver)
        {
            rigidBody2d.velocity = Vector2.up * upForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.endGame();
    }
}
