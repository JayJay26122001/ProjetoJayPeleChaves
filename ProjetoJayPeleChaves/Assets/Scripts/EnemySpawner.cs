using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float minSpawnTime, maxSpawnTime, timeUntilSpawn, minY, maxY, spawnerMoveSpeed;

    private void Awake()
    {
        RandomTimeSpawn();
    }

    private void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if(timeUntilSpawn <= 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            RandomTimeSpawn();
        }
    }

    public void RandomTimeSpawn()
    {
        timeUntilSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    public void MoveSpawner()
    {
        float newY = Mathf.PingPong(Time.deltaTime * spawnerMoveSpeed, maxY - minY) + maxY;
        transform.position = new Vector3(0, newY, 0);
    }
}
