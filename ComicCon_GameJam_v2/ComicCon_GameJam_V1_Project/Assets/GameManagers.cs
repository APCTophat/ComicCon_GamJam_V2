using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public int Goal;
    public int GoalCounter;
    // Start is called before the first frame update

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
}
