﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{
    GameManagers GameManagers;
    GameObject GameManager;
    GameObject StandardCube;
    private int TreadedOnTimes;
    public int NumTreadTimesTillGoal;

    public AudioSource TreeSound;

    private Animator ThisObjectsAnim;
    private bool TileGoalMet ;

    bool Interacted = false;
    Renderer Rn_Player;

    private void Awake()
    {
        ThisObjectsAnim = GetComponent<Animator>();
        TreadedOnTimes = 0;
        ThisObjectsAnim.SetInteger("NumTimesTouched", TreadedOnTimes);
    }

    void Start()
    {
        StandardCube = this.gameObject;
        GameManager = GameObject.FindGameObjectWithTag("Game Manager");
        GameManagers = GameManager.GetComponent<GameManagers>();
        Rn_Player = gameObject.GetComponent<Renderer>();
        TileGoalMet = false;
        Rn_Player.material.color = Color.blue;  
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Collider");
        if (other.gameObject.tag == "Player")
        {
            SwapBlockType();
            Debug.Log("Collider");
            if(TreadedOnTimes < NumTreadTimesTillGoal)
            {
                TreadedOnTimes++;
            }
            else
            {
                TileGoalMet = false;
                TreadedOnTimes++;
            }
            BlockInteraction();
            ThisObjectsAnim.SetInteger("NumTimesTouched", TreadedOnTimes);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (TreadedOnTimes == 2 && (gameObject.tag!= ("Ice")))
        {
            ThisObjectsAnim.Play("Tree");
            StandardCube.GetComponent<StandardCube>().SetBlockSolid();

            TreeSound.Play();
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
        else if(TreadedOnTimes > NumTreadTimesTillGoal)
        {
            TreadedOnTimes -= 2;
            GameManagers.ScoreDecrease(TileGoalMet);
        }
        else
        {

        }
    }
    
    
}
