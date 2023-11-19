using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideGround : MonoBehaviour
{
    public float rotationSpeed = 20f;

    // Oyunun her karesinde objenin dönüşünü güncelleyelim
    void Update()
    {
       transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
