using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleTriggerScript : MonoBehaviour
{
    private logicScript logicScript;
    private audioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (logicScript == null) { return; }
        if (collision.gameObject.layer == 3)
        {
            logicScript.updatePlayerScore(1);
            audioManager.PlaySFX(audioManager.score);
        }
    }
}
