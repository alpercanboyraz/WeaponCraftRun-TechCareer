using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GetPrize : MonoBehaviour
{

    public float moveDistance = 3f; // Hareket mesafesi
    public float moveDuration = 2f; // Hareket süresi


    public void Init()
    {
        EventManager.OnGetPrize += OnGetPrize;
    }

     private void OnGetPrize()
     {
        Debug.Log("run");

        Vector3 initialPosition = transform.position;

         transform.DOMoveX(initialPosition.x + moveDistance, moveDuration)
            .SetEase(Ease.Linear);
        
        
    }

    private void OnDestroy()
    {
        EventManager.OnGetPrize -= OnGetPrize;
    }
}
