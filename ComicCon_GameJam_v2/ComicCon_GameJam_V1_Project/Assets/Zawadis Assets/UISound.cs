using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISound : MonoBehaviour
{
    public AudioSource HoverSound;
    public AudioSource PressSound;

    public void Hover()
    {
        HoverSound.Play();
    }

    public void Press()
    {
        PressSound.Play();
    }
}
