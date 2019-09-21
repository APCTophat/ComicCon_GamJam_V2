using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Goal;
    public int GoalCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoalComplete()
    {

    }
    public void ScoreIncrease(bool scored)
    {
        if( scored == true)
        {
            GoalCounter++;
        }
    }
}
