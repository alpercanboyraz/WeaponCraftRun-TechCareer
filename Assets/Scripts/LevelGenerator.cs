using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [Header("Border Settings")]
    [SerializeField] private float _startZPosition;
    [SerializeField] private float _endZPosition;
    [SerializeField] private float _leftBorder;
    [SerializeField] private float _rightBorder;

    [Header("Prefabs")]
    [SerializeField] private GameObject _RangePrefab;
    [SerializeField] private GameObject _RatePrefab;
    [SerializeField] private GameObject _PrizePrefab;

    [Header("Spawn Settings")]
    [SerializeField] private float _RangeSpawnDistance;
    [SerializeField] private float _RateSpawnDistance;
    [SerializeField] private float _PrizeSpawnDistance;

    public void Init()
    {
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        int RangeSpawnCount = Mathf.FloorToInt((_endZPosition - _startZPosition) / _RangeSpawnDistance);
        int RateSpawnCount = Mathf.FloorToInt((_endZPosition - _startZPosition) / _RateSpawnDistance);
        int PrizeSpawnDistance = Mathf.FloorToInt((_endZPosition - _startZPosition) / _PrizeSpawnDistance);

        for (int i = 1; i <= RangeSpawnCount; i++)
        {
            GameObject rangeWindow = Instantiate(_RangePrefab);
            Vector3 spawnPosition = new Vector3(Random.Range(_leftBorder, _rightBorder), 0.5f, _startZPosition + _RangeSpawnDistance * i);
            rangeWindow.transform.position = spawnPosition;
        }

        for (int i = 1; i <= RateSpawnCount; i++)
        {
            GameObject RateWindow = Instantiate(_RatePrefab);
            Vector3 spawnPosition = new Vector3(Random.Range(_leftBorder, _rightBorder), 0.5f, _startZPosition + _RateSpawnDistance * i);
            RateWindow.transform.position = spawnPosition;
        }

        for (int i = 1; i <= PrizeSpawnDistance; i++)
        {
            GameObject obstacle = Instantiate(_PrizePrefab);
            
            Vector3 spawnPosition = new Vector3(Random.Range(_leftBorder, _rightBorder), 0.3899997f, _startZPosition + _PrizeSpawnDistance * i);
            obstacle.transform.position = spawnPosition;
        }

    }
}
