using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerExample : MonoBehaviour
{
    public Animator myself;
    private Transform PlayerVector;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        PlayerVector = GetComponent<Transform>();
        myself.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            myself.Play("Jump");
            PlayerVector.position = Vector3.MoveTowards(PlayerVector.position, PlayerVector.position + new Vector3(0, 0, 1), speed * Time.deltaTime);
        }
        else
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            myself.Play("Jump");
        }
        else
        {
            myself.Play("Idle");
        }
    }
}
