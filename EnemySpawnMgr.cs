using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMgr : MonoBehaviour
{
    //Array with  all the enemy prefabs 
    public GameObject[] enemyPrefabs;

    //The horizontal range between which the enemies will be spawned at random
    private float spawnRangeX = 14.5f;

    //A spawn position off the screen
    private float spawnPosZ = 9.0f;

    //Game timer
    public float time = 0.0f;

    //Spawn timer 
    public float spawnTimer = 0.0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Following block of if statements is for debug purposes only
        if(Input.GetKeyDown(KeyCode.G))
        {
            SpawnEnemy1();
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            SpawnEnemy2();
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            SpawnEnemy3();
        }

        //Game Timer
        time += Time.deltaTime;

        //Enemy spawn timer
        spawnTimer += Time.deltaTime;
        
        //Random generator to determine which enemy will spawn
        float spawnRandomValue = Random.Range(0.0f, 1.0f);

        //Difficulty in enemy spawning
        if(time < 30)
        {
            if(spawnTimer > 2.50)
            {
                if(spawnRandomValue < 0.50f)
                {
                    SpawnEnemy1();
                } else if(spawnRandomValue >= 0.50f && spawnRandomValue < 0.80f)
                {
                    SpawnEnemy2();
                } else
                {
                    SpawnEnemy3(); 
                }
                spawnTimer = 0.0f;
            }

        } else if(time >= 30 && time < 90)
        {
            if (spawnTimer > 1.80)
            {
                if (spawnRandomValue < 0.20f)
                {
                    SpawnEnemy1();
                }
                else if (spawnRandomValue >= 0.20f && spawnRandomValue < 0.70f)
                {
                    SpawnEnemy2();
                }
                else
                {
                    SpawnEnemy3();
                }
                spawnTimer = 0.0f;
            }

        } else if(time >= 90)
        {
            if (spawnTimer > 1.0)
            {
                if (spawnRandomValue < 0.20f)
                {
                    SpawnEnemy1();
                }
                else if (spawnRandomValue >= 0.20f && spawnRandomValue < 0.50f)
                {
                    SpawnEnemy2();
                }
                else
                {
                    SpawnEnemy3();
                }
                spawnTimer = 0.0f;
            }
        }

    }

    void SpawnEnemy1()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2.5f, spawnPosZ);
        GameObject o = Instantiate(enemyPrefabs[0], spawnPos, enemyPrefabs[0].transform.rotation);
        o.GetComponent<EnemyHealth>().health = 3;
        o.GetComponent<EnemyGeneralMovement>().speed = 4;
        o.GetComponent<EnemyHealth>().dealsDamage = 5;

    }

    void SpawnEnemy2()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2.5f, spawnPosZ);
        GameObject o = Instantiate(enemyPrefabs[1], spawnPos, enemyPrefabs[1].transform.rotation);
        o.GetComponent<EnemyHealth>().health = 7;
        o.GetComponent<EnemyGeneralMovement>().speed = 3;
        o.GetComponent<EnemyHealth>().dealsDamage = 10;


    }

    void SpawnEnemy3()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2.5f, spawnPosZ);
        GameObject o = Instantiate(enemyPrefabs[2], spawnPos, enemyPrefabs[0].transform.rotation);
        o.GetComponent<EnemyHealth>().health = 10;
        o.GetComponent<EnemyGeneralMovement>().speed = 2;
        o.GetComponent<EnemyHealth>().dealsDamage = 20;
    }
}
