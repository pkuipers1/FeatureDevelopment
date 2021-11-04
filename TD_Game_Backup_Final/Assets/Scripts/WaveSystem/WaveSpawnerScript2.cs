using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnerScript2 : MonoBehaviour
{
    [SerializeField] private GameObject currentEnemyA;
    [SerializeField] private GameObject currentEnemyB;

    public GameObject slimeGreen;
    public GameObject slimeBlue;
    public GameObject slimeRed;
    public GameObject slimeYellow;
    public GameObject slimeBlack;

    public float timeBetweenWavesSmall = 5f;
    public float timeBetweenWavesLarge = 10f;

    public float countdown = 2f;

    int waveNumber = 1;
    int waveStage = 1;

    private void Start()
    {
        AssignEnemy();
    }

    void Update()
    {
        if (countdown <= 0)
        {
            if (waveStage == 1)
            {
                StartCoroutine(SpawnEnemyWave1());
                countdown = timeBetweenWavesSmall;

                waveNumber += 1;
            }

            else if (waveStage == 2)
            {
                StartCoroutine(SpawnEnemyWave2());
                countdown = timeBetweenWavesLarge;

                waveNumber += 1;
            }

            else if (waveStage == 3)
            {
                StartCoroutine(SpawnEnemyWave3());
                countdown = timeBetweenWavesLarge;

                waveNumber += 1;
            }
        }

        countdown -= Time.deltaTime;
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }

    IEnumerator SpawnEnemyWave1()
    {
        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        waveStage = 2;
        AssignEnemy();
    }

    IEnumerator SpawnEnemyWave2()
    {
        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyB);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        waveStage = 3;
        AssignEnemy();
    }

    IEnumerator SpawnEnemyWave3()
    {
        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyB);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyB);
        yield return new WaitForSeconds(1);

        SpawnEnemy(currentEnemyA);
        yield return new WaitForSeconds(1);

        waveStage = 1;
        AssignEnemy();
    }

    void AssignEnemy()
    {
        if (waveNumber == 1 || waveNumber == 2 || waveNumber == 3)
        {
            currentEnemyA = slimeGreen;
            currentEnemyB = slimeBlue;
        }
        else if (waveNumber == 4 || waveNumber == 5 || waveNumber == 6)
        {
            currentEnemyA = slimeBlue;
            currentEnemyB = slimeRed;
        }
        else if (waveNumber == 7 || waveNumber == 8 || waveNumber == 9)
        {
            currentEnemyA = slimeRed;
            currentEnemyB = slimeYellow;
        }
        else if (waveNumber == 10 || waveNumber == 11 || waveNumber == 12)
        {
            currentEnemyA = slimeYellow;
            currentEnemyB = slimeBlack;
        }
        else if (waveNumber >= 13)
        {
            currentEnemyA = slimeBlack;
            currentEnemyB = slimeBlack;
        }
    }
}
