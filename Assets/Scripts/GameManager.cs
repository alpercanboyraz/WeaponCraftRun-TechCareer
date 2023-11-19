using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool tutorialControl = true;
    public void Init()
    {
       
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0) && tutorialControl)
        {
            StartMovement();
            tutorialControl = false;
        }
    }

    public void StartMovement()
    {
        EventManager.Instance.SetStartProgressBar();
        EventManager.Instance.SetStartMovement();
    }
}
