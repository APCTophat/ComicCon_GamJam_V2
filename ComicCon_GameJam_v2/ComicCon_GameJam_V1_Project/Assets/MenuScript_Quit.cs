using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript_Quit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}
