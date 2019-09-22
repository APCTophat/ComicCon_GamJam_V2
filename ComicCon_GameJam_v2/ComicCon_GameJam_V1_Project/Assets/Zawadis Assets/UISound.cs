using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound : MonoBehaviour
{
    public AudioSource HoverSound;

    void Hover()
    {
        HoverSound.Play();
    }
}
