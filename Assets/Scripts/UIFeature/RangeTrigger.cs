using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RangeTrigger : MonoBehaviour
{

    [SerializeField] private TextMeshPro _rangeText;

    private float _rangeValue = 0;
    public void Init()
    {
        EventManager.OnRangeIncrease += OnRangeIncreaseText;
    }

    private void OnRangeIncreaseText(float range)
    {
        _rangeValue = range;
        _rangeText.text = "Range : " + _rangeValue.ToString();
    }

    private void FixedUpdate()
    {
        if (_rangeText != null)
        {
            // Debug.Log(_rangeValue);
            _rangeText.text = "Range : " + _rangeValue.ToString();
        }
    }

    /*private void OnDestroy()
    {
        EventManager.OnRangeIncrease -= OnRangeIncrease;
    }*/
}
