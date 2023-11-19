using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition; 
    public float transformSpeed = 5f; 

    void LateUpdate()
    {
        if (playerPosition != null)
        {
            
            Vector3 targetPosition = new Vector3(playerPosition.position.x,playerPosition.position.y+2.4f,playerPosition.position.z-3f);

            
            transform.position = Vector3.Lerp(transform.position, targetPosition, transformSpeed * Time.deltaTime);
        }
    }
}
