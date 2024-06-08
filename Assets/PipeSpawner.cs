using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    private float timer = 0;
    private float spawnRate = 2;
    public int heightOffSet = 10;
    private logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isGameOver) { return; }
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), transform.position.z), transform.rotation);
    }
}
