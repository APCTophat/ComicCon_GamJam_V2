using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalTextDisplay : MonoBehaviour
{
    Text ThisObject;
    public GameObject GameManagers;
    // Start is called before the first frame update
    void Start()
    {
        ThisObject = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //ThisObject.text = GameManagers.GetComponent<GameManagers>().Goal+"/"+GameManagers.GetComponent<GameManagers>().GoalCounter;

        ThisObject.text = GameManagers.GetComponent<GameManagers>().GoalCounter + "/" + GameManagers.GetComponent<GameManagers>().Goal;
    }
}
