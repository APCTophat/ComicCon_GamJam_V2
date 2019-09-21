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

    bool Interacted = false;
    Renderer Rn_Player;
    void Start()
    {
        GameManagers = GameManager.GetComponent<GameManagers>();
        Rn_Player = gameObject.GetComponent<Renderer>();
        TreadedOnTimes = 0;
        TileGoalMet = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        SwapBlockType();
        Debug.Log("Collider");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collider");
            TreadedOnTimes++;
            BlockInteraction();
        }
    }

    void SwapBlockType()
    {
        if (Interacted == false)
        {
            Rn_Player.material.color = Color.red;
            Interacted = !Interacted;
        }
        else if (Interacted == true)
        {
            Rn_Player.material.color = Color.blue;
            Interacted = !Interacted;
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
