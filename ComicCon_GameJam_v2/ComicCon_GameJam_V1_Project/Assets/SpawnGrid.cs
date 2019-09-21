using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour
{
    public GameObject LevelPiece;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            float xpos = i;
            for (int j = 0; j < 10; j++)
            {
                float zpos = j;
                Instantiate(LevelPiece, new Vector3(xpos,-0.5f,zpos), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
