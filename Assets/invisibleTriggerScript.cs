using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleTriggerScript : MonoBehaviour
{
    public logicScript logicScript;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (logicScript == null) { return; }
        if (collision.gameObject.layer == 3)
        {
            logicScript.updatePlayerScore(1);
        }
    }
}
