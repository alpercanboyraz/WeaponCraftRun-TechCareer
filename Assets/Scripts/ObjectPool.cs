using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    
    public Queue<GameObject> pooledObjects;
    public GameObject objectPrefab;
    public int poolSize;
    

    // [SerializeField] private Pool[] pools = null;

    private void Awake()
    {
        pooledObjects = new Queue<GameObject>();
        
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);

            pooledObjects.Enqueue(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledObjects.Dequeue();

        obj.SetActive(true);

        pooledObjects.Enqueue(obj);

        return obj;
    }
}