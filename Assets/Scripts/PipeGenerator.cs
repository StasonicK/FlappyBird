using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeGenerator : ObjectPool
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _secondsBetweenSpawns;
    [SerializeField] private float _maxSpawnPosition;
    [SerializeField] private float _minSpawnPosition;

    private float _elapsedTime = 0;

    private void Start()
    {
        Init(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _secondsBetweenSpawns)
        {
            if (TryGetObject(out GameObject pipe))
            {
                _elapsedTime = 0;

                float spawnPositionY = Random.Range(_minSpawnPosition, _maxSpawnPosition);
                Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
                pipe.SetActive(true);
                pipe.transform.position = spawnPoint;
                
                DisableObjectAbroadScreen();
            }
        }
        
    }
}