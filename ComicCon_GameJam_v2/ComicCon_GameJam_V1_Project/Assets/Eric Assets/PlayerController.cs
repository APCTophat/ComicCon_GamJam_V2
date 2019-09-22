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

    public AudioSource MoveSound;

    float LerpSpeed = 0.1f;

    bool Move = false;
    RaycastHit hit;

    Vector3[] Directions;
    bool[] DirectionOK;


    void Start()
    {
        Tr_Player = gameObject.GetComponent<Transform>();
        Directions = new Vector3[4];
        Directions[0] = Vector3.forward;
        Directions[1] = Vector3.back;
        Directions[2] = Vector3.right;
        Directions[3] = Vector3.left;

        DirectionOK = new bool[4];
        for (int i = 0; i < 4; i++)
        {
            DirectionOK[i] = true;
        }

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
                    DirectionOK[i] = false;
                }
                else
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Directions[i]) * 10, Color.white);
                    DirectionOK[i] = true;
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

        if (Input.GetKeyDown(KeyCode.W) && DirectionOK[0] == true)
        {
            LerpEnd = new Vector3(Tr_Player.position.x, Tr_Player.position.y, Tr_Player.position.z + MovementUnit);
            SetLerpCharacter();

            MoveSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.S) && DirectionOK[1] == true)
        {
            LerpEnd = new Vector3(Tr_Player.position.x, Tr_Player.position.y, Tr_Player.position.z - MovementUnit);
            SetLerpCharacter();

            MoveSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.A) && DirectionOK[3] == true)
        {
            LerpEnd = new Vector3(Tr_Player.position.x - MovementUnit, Tr_Player.position.y, Tr_Player.position.z);
            SetLerpCharacter();

            MoveSound.Play();
        }
        if (Input.GetKeyDown(KeyCode.D) && DirectionOK[2] == true)
        {
            LerpEnd = new Vector3(Tr_Player.position.x + MovementUnit, Tr_Player.position.y, Tr_Player.position.z);
            SetLerpCharacter();

            MoveSound.Play();
        }
    }

    void SetLerpCharacter()
    {
        LerpStart = Tr_Player.position;
        An_Player.SetTrigger("Jump");
        Move = true;
    }
}
