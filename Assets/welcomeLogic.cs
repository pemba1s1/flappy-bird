using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeLogic : MonoBehaviour
{
    public GameObject quitScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startGame() {
        SceneManager.LoadScene("GameScene");
    }

    public void quitGame() {
        quitScreen.SetActive(true);
    }

    public void confirmQuit() {
        Application.Quit();
    }

    public void cancelQuit() {
        quitScreen.SetActive(false);
    }
}
