using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string MainMenu;

    public GameObject pausemenu;

    public bool IsPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                ResumeGame();
            }
            else
            {
                IsPaused = true;
                pausemenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame()
    {
        IsPaused = (false);
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(MainMenu);
    }
}
