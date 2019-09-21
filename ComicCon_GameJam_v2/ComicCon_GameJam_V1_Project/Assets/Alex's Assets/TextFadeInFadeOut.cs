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

        level_Title = GetComponent<Text>();
        timer = new Timer(timeToChange, InFade);
        timer.Update = FadeIn;
       
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
        timer = new Timer(timeToChange, () =>
        {
            var color = level_Title.color;
            color.a = 0;
            level_Title.color = color;
        });
        timer.Update = FadeOut;
    }

    private void OutFade()
    {
        ///evel_Title.CrossFadeAlpha(0f, timeToChange, false);
    }
}
