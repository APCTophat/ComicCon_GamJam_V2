using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string Scene;


    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Scene);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(Scene);
    }


}
