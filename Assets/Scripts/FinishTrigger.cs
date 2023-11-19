using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetObj;
    public void Init()
    {
        EventManager.OnFinishGame += OnFinishGame;
    }

    private void OnFinishGame()
    {
      
        if (targetObj != null)
        {
            SpawnBullet spawnBullet = targetObj.GetComponent<SpawnBullet>();
            if (spawnBullet != null)
            {
                
                spawnBullet.enabled = false;
            
            }
        }
    
}
}
