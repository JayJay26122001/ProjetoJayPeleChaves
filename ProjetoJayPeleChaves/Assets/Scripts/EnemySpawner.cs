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
        MoveSpawner();
    }

    public void RandomTimeSpawn()
    {
        timeUntilSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    public void MoveSpawner()
    {
        float newY = Mathf.PingPong(Time.time * spawnerMoveSpeed, maxY - minY) + minY;
        transform.position = new Vector3(10, newY, 0);
    }
}
