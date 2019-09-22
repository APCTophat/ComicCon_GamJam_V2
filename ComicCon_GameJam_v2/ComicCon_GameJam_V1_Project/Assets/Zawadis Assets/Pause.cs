using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool IsPaused = false;

    public GameObject pausePanel;

    public GameObject pauseText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
                Time.timeScale = 1f;
            }
            else
            {
                PauseGame();
                Time.timeScale = 0f;
            }
        }
    }

    public void Resume()
    {
        pausePanel.SetActive(false);

        pauseText.SetActive(true);

        Time.timeScale = 1f;

        IsPaused = false;
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);

        pauseText.SetActive(false);

        Time.timeScale = 0f;

        IsPaused = true;
    }

    public void Home()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1f;
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene(5);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
