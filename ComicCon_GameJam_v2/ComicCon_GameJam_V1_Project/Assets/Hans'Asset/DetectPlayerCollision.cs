using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{
    GameManagers GameManagers;
    private int TreadedOnTimes;
    public int NumTreadTimesTillGoal;
   GameObject GameManager;

    private bool TileGoalMet ;

    public StandardCube CubeType;

    void Start()
    {
        
        GameManager = GameObject.FindGameObjectWithTag("Game Manager");
        GameManagers = GameManager.GetComponent<GameManagers>();
        TreadedOnTimes = 0;
        TileGoalMet = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && CubeType.CubeType == 0)
        {
            CubeType.SwapBlockType();
            Debug.Log("Collider");
            TreadedOnTimes++;
            BlockInteraction();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && CubeType.CubeType == 1)
        {
            CubeType.SetBlockSolid();
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
