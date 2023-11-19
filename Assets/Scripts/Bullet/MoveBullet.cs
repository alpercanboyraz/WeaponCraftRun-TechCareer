using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public int _moveSpeed = 5;

   

    void Update()
    {
        Debug.Log(_moveSpeed);
        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);
    }
    
}
