using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startGame() {
        SceneManager.LoadScene("GameScene");
    }
}
