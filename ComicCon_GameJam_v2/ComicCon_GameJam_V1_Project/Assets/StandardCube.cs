using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardCube : MonoBehaviour
{
    bool Interacted = false;
    Renderer Rn_Player;
    public int CubeType;
   
    // Start is called before the first frame update
    void Start()
    {
        Rn_Player = gameObject.GetComponent<Renderer>();
        if (CubeType == 0)
        {
            Rn_Player.material.color = Color.blue;
        }
        if (CubeType == 1)
        {
            Rn_Player.material.color = Color.green;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBlockSolid()
    {
        
        this.gameObject.tag = "Barrier";
    }

    public void SwapBlockType()
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
}
