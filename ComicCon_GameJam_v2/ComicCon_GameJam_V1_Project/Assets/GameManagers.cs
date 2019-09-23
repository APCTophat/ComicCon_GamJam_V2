using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public int Goal;
    public int GoalCounter;
    public GameObject LevelFinishUI;
    private bool WonOnce = false, SoundPlayer = false;
    public AudioSource WinSound;

    // Start is called before the first frame update
    private void Update()
    {
        if(GoalCounter == Goal)
        {
            LevelFinishUI.SetActive(true);
            WonOnce = true;
        }
        if (WonOnce == true && SoundPlayer == false)
        {
            GoalComplete();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LevelFinishUI.SetActive(true);
        }
    }
    void GoalComplete()
    {
        WinSound.Play();
        SoundPlayer = true;
    }
    public void ScoreIncrease(bool scored)
    {
        if (scored == true)
        {
            GoalCounter++;
        }
    }
    public void ScoreDecrease(bool scored)
    {
        if(scored == false)
        {
            GoalCounter--;
        }
    }
}
