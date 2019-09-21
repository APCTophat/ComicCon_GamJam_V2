using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform Tr_Player;
    public float MovementUnit;
    Animator An_Player;

    Vector3 LerpStart;
    Vector3 LerpEnd;

    float LerpSpeed = 0.1f;

    bool Move = false;

    void Start()
    {
        Tr_Player = gameObject.GetComponent<Transform>();
        An_Player = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Move == false)
        {
            CheckInput();
        }
        LerpCharacter();
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
        LerpStart = new Vector3(Tr_Player.position.x, Tr_Player.position.y, Tr_Player.position.z);
        Move = true;
    }
}
