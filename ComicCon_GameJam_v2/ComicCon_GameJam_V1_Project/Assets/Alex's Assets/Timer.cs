using UnityEngine;
using System.Collections;
using System;

public class Timer
{
    private float amount;
    public float Amount { get => amount; }

    public float CurrentTime { get; private set; }
    public Action<float, float> Update;

    public float NormlisedTime
    {
        get
        {
            return CurrentTime / Amount;
        }
    }

    private Action complete;

    

    public Timer (float amount, Action onComplete)
    {
        this.amount = CurrentTime = amount;
        complete = onComplete;
    }

    public void Tick (float deltaTime)
    {
        CurrentTime -= deltaTime;
        if ( Update != null )
        {
            Update(CurrentTime, NormlisedTime);
        }
        if (CurrentTime <= 0 )
        {
            if ( complete != null )
            {
                complete();
            }
        }
    }

}
