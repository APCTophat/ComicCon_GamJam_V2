using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject missionAccomplished;

    float theTime = 0f;
    public float initialTime = 10f;

    public static bool IsOver = false;

    [SerializeField] Text countText;

    void Start()
    {
        theTime = initialTime;
    }

    private void Update()
    {
        theTime -= 1 * Time.deltaTime;
        print(theTime);
        countText.text = theTime.ToString("Time: 0");

        if (theTime <= 0)
        {
            theTime = 0;
            Game_Over();
        }
    }

    public void Mission_Accomplished()
    {
        missionAccomplished.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Game_Over()
    {
        gameOver.SetActive(true);

        Time.timeScale = 0f;
    }

    //For Home Scene
    public void Play()
    {
        SceneManager.LoadScene(1);

        Time.timeScale = 1f;
    }

    public void Advance1()
    {
        SceneManager.LoadScene(2);

        missionAccomplished.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
    }

    public void Advance2()
    {
        SceneManager.LoadScene(3);

        missionAccomplished.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
    }

    public void Advance3()
    {
        SceneManager.LoadScene(4);

        missionAccomplished.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        gameOver.SetActive(false);
        missionAccomplished.SetActive(false);

        Time.timeScale = 1f;
    }
}
