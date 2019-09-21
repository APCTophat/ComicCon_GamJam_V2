using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public int Goal;
    public int GoalCounter;
    public GameObject LevelFinishUI;
    // Start is called before the first frame update
    private void Update()
    {
        if(GoalCounter == Goal)
        {
            LevelFinishUI.SetActive(true);
        }
    }
    void GoalComplete()
    {

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
