using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // [x] - Monster list
    // [x] - Pick random monster
    // [x] - Spawn monster
    // [ ] - Spawn timer

    public GameObject[] monsters;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    private float spawnTime;

    void Start()
    {
        setSpawnTime();
    }

    void Update()
    {
        SpawnMonster();
    }

    private GameObject PickRandomMonster()
    {
        int monstersCount = monsters.Length;
        int monsterIndex = Random.Range(0, monstersCount);

        return monsters[monsterIndex];
    }

    private void InstantiateMonster()
    {
        GameObject monster = PickRandomMonster();
        Instantiate(monster, transform);
    }

    private void SpawnMonster()
    {
        if (Time.time >= spawnTime)
        {
            InstantiateMonster();
            setSpawnTime();
        }
        
    }

    private void setSpawnTime()
    {
        spawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
    }
}
