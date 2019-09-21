using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeInFadeOut : MonoBehaviour
{
    [SerializeField]
    private Text level_Title;

    [SerializeField]
    private float timeToChange;

    private Timer timer;

    private List<GameObject> games;
    private List<float> floats;
  
    private void Start()
    { 
        level_Title.CrossFadeAlpha(0f, 0f, false);

        timer = new Timer(timeToChange, InFade);
        timer.Update = FadeIn;
        //Invoke("InFade", timeToChange);
    }

    private void Update()
    {
        if ( timer == null )
        {
            return;
        }
        timer.Tick(Time.deltaTime); 
    }

    private void FadeIn(float currentTime, float normalisedTime)
    {
        Color titleColor = level_Title.color;
        titleColor.a = 1 - normalisedTime;
        level_Title.color = titleColor;  
    }

    private void FadeOut(float currentTime, float normalisedTime)
    {
        Color titleColor = level_Title.color;
        titleColor.a = normalisedTime;
        level_Title.color = titleColor;
    }

    private void InFade()
    {
        level_Title.CrossFadeAlpha(1f, timeToChange, false);
        //Invoke("OutFade", timeToChange);
        timer = new Timer(timeToChange, OutFade);
    }
    private void OutFade()
    {
        level_Title.CrossFadeAlpha(0f, timeToChange, false);
    }
}
