using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class ProgressBar : MonoBehaviour
{
    public Image fillImage;
    public float fillDuration = 5f;

    void Start()
    {

        EventManager.OnStartProgressBar += OnStartProgressBar;
       
    }private void OnStartProgressBar()
    {
        fillImage.fillAmount = 0f;


        fillImage.DOFillAmount(1f, fillDuration)
            .SetEase(Ease.Linear);
    }
}
