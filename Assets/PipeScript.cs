using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed;
    private float destroyPoint = -35;
    private logicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isGameOver) { return; }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < destroyPoint)
        {
            Destroy(gameObject);
        }
    }

}
