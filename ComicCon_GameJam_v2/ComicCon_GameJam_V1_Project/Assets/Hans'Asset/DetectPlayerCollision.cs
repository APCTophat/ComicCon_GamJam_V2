using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{
    GameManager GameManagers;
    private int TreadedOnTimes;
    public int NumTreadTimesTillGoal;
   

    private bool TileGoalMet = false;

    void Start()
    {
        TreadedOnTimes = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TreadedOnTimes++;
            BlockInteraction();
        }
    }
    public void BlockInteraction()
    {
        if (TreadedOnTimes == NumTreadTimesTillGoal)
        {
            TileGoalMet = true;
            GameManagers.ScoreIncrease(TileGoalMet);
        }
        else
        {

        }
    }
    
    
}
