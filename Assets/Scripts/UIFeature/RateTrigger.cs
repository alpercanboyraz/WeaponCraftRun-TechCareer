using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RateTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshPro _rateText;

    private float _rateValue = 0;
    public void Init()
    {
        EventManager.OnRateIncrease += OnRateIncreaseText;
    }

    private void OnRateIncreaseText(float rate)
    {
        _rateValue = rate;
        _rateText.text = "Rate : " + _rateValue.ToString();
        Debug.Log(_rateText.text);

       
    }
    
    private void FixedUpdate()
    {

        if (_rateText != null)
        {
            // Debug.Log(_rateValue);
            _rateText.text = "Rate : " + _rateValue.ToString();
        }
    }

  
}
