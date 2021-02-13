using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour {
    public string ScenetoChangeto;

    public void changeScene() {
        SceneManager.LoadScene(ScenetoChangeto);
    }
    public void quitGame()
    {
        Application.Quit(0);
    }
    public void reloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}