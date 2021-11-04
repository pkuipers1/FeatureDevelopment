using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject slimeEnemy;

    private float spawnTimer;

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        spawnSlime();
    }

    void spawnSlime()
    {
        if (spawnTimer <= 0)
        {
            Instantiate(slimeEnemy, transform.position, Quaternion.identity);

            int randomTime = Random.Range(2, 9);

            spawnTimer += randomTime;
        }
    }
}