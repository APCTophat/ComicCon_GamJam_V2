using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform Tr_Player;
    public float MovementUnit;
    public Animator An_Player;

    Vector3 LerpStart;
    Vector3 LerpEnd;

    float LerpSpeed = 0.1f;

    bool Move = false;
    RaycastHit hit;

    Vector3[] Directions;



    void Start()
    {
        Tr_Player = gameObject.GetComponent<Transform>();
        Directions = new Vector3[4];
        Directions[0] = Vector3.forward;
        Directions[1] = Vector3.back;
        Directions[2] = Vector3.right;
        Directions[3] = Vector3.left;
    }

    void Update()
    {
        CheckifCanMove();
        if (Move == false)
        {
            CheckInput();
        }
        LerpCharacter();
    }

    void CheckifCanMove()
    {

        for (int i = 0; i < 4; i++)
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Directions[i]), out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "Barrier")
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Directions[i]) * hit.distance, Color.green);
                }
                else
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Directions[i]) * 10, Color.white);
                }
            }
        }

    }


    void LerpCharacter()
    {   if (Move == true)
        {
            LerpSpeed = LerpSpeed + 0.1f;
            Tr_Player.position = Vector3.Lerp(LerpStart, LerpEnd, LerpSpeed);
            if (Tr_Player.position == LerpEnd)
            {
                Move = false;
                LerpSpeed = 0;
            }
        }
    }

    void CheckInput()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            LerpEnd = new Vector3(Tr_Player.position.x, Tr_Player.position.y, Tr_Player.position.z + MovementUnit);
            SetLerpCharacter();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            LerpEnd = new Vector3(Tr_Player.position.x, Tr_Player.position.y, Tr_Player.position.z - MovementUnit);
            SetLerpCharacter();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            LerpEnd = new Vector3(Tr_Player.position.x - MovementUnit, Tr_Player.position.y, Tr_Player.position.z);
            SetLerpCharacter();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            LerpEnd = new Vector3(Tr_Player.position.x + MovementUnit, Tr_Player.position.y, Tr_Player.position.z);
            SetLerpCharacter();
        }
    }

    void SetLerpCharacter()
    {
        LerpStart = Tr_Player.position;
        An_Player.SetTrigger("Jump");
        Move = true;
    }
}
