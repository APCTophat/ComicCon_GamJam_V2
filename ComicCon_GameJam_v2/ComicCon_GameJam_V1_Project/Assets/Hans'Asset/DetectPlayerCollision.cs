using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{
    GameManagers GameManagers;
    private int TreadedOnTimes;
    public int NumTreadTimesTillGoal;
    public GameObject GameManager;

    private bool TileGoalMet ;

    void Start()
    {
        GameManagers = GameManager.GetComponent<GameManagers>();
        TreadedOnTimes = 0;
        TileGoalMet = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collider");
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
