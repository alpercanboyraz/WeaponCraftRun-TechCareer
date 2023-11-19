using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;
    
    public delegate void VoidDelegate();

    public static event VoidDelegate OnStartMovement,OnGameOverSceene,
        OnFinishGame,OnGetPrize,OnStartProgressBar;
    
    public delegate void RangeIncrease(float f);
    public static event RangeIncrease OnRangeIncrease;

    public delegate void RateIncrease(float f);
    public static event RateIncrease OnRateIncrease;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void SetStartMovement()
    {
        if (OnStartMovement != null)
        {
            OnStartMovement();
        }
    }
    public void SetGameOverSceene()
    {
        if (OnGameOverSceene != null)
        {
            OnGameOverSceene();
        }
    }

    public void SetFinishGame()
    {
        if (OnFinishGame != null)
        {
            OnFinishGame();
        }
    }

    public void SetGetPrize()
    {
        if (OnGetPrize != null)
        {
            OnGetPrize();
        }
    }

    public void SetStartProgressBar()
    {
        if (OnStartProgressBar != null)
        {
            OnStartProgressBar();
        }
    }

    public void SetRangeIncrease(float Range)
    {
        if (OnRangeIncrease != null)
        {
            OnRangeIncrease(Range);
        }
    }

    public void SetRateIncrease(float rate)
    {
        if (OnRateIncrease != null)
        {
            OnRateIncrease(rate);
        }
    }
}
