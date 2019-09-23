using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFollow : MonoBehaviour
{
    public Text Exittext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ExitTextPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        Exittext.transform.position = ExitTextPosition;
    }
}
