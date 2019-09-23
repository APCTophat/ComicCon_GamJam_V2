using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour
{
    private float PositionY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        PositionY = Mathf.PingPong(Time.time, 0.5f);
        transform.localPosition = new Vector3(transform.localPosition.x, PositionY, transform.localPosition.z);
    }
}
