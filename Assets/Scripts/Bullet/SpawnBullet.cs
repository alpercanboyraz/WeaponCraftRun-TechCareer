using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;

    [SerializeField] private ObjectPool objectPool = null;
    [SerializeField] private GameObject startPosition;

  

    void Start()
    {
        EventManager.OnFinishGame += OnFinishGame;
        StartCoroutine(nameof(SpawnRoutine));
    }
    private void OnFinishGame()
    {
        StopCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {

        while (true)
        {

            var obj = objectPool.GetPooledObject();
            obj.transform.position = startPosition.transform.position;
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
