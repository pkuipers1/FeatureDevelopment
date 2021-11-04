// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// 
// public class WaveSpawner : MonoBehaviour
// {
//     public GameObject slimeGreen;
//     public GameObject slimeRed;
//     public GameObject slimeBlue;
//     public GameObject slimeYellow;
//     public GameObject slimeBlack;
// 
//     public float timer;
// 
//     [SerializeField] GameObject currentEnemyA;
//     [SerializeField] GameObject currentEnemyB;
// 
//     [SerializeField] int waveCounter123 = 1;
//     // [SerializeField] GameObject[] currentWave;
// 
//     GameObject[] arrayWave1 = new GameObject[3];
//     GameObject[] arrayWave2 = new GameObject[5];
//     GameObject[] arrayWave3 = new GameObject[4];
// 
//     private void Start()
//     {
//         currentEnemyA = slimeGreen;
//         currentEnemyB = slimeBlue;
// 
//         arrayWave1 = { currentEnemyA, currentEnemyA, currentEnemyA };
//         arrayWave1[1] = currentEnemyB;
//         arrayWave1[2] = currentEnemyA;
// 
//         arrayWave2[0] = currentEnemyA;
//         arrayWave2[1] = currentEnemyA;
//         arrayWave2[2] = currentEnemyB;
//         arrayWave2[3] = currentEnemyA;
//         arrayWave2[4] = currentEnemyA;
// 
//         arrayWave3[0] = currentEnemyA;
//         arrayWave3[1] = currentEnemyA;
//         arrayWave3[2] = currentEnemyB;
//         arrayWave3[3] = currentEnemyB;
// 
//         // SpawnWave1();
//     }
// 
//     private void Update()
//     {
//         timer -= Time.deltaTime;
// 
//         if(timer <= 0)
//         {
//             instantiateEnemies1(arrayWave1);
//         }
//     }
// 
//     IEnumerator instantiateEnemies1(GameObject[] enemies)
//     {
//         timer += 8;
//         Instantiate(enemies[0], transform.position, Quaternion.identity);
//         yield return new WaitForSeconds(2);
//         Instantiate(enemies[1], transform.position, Quaternion.identity);
//         yield return new WaitForSeconds(2);
//         Instantiate(enemies[2], transform.position, Quaternion.identity);
//         yield return new WaitForSeconds(2);
//     }
// 
//     private void SpawnWave1()
//     {
//         foreach (GameObject enemy in arrayWave1)
//         {
//             //if (timer <= 0)
//             //{
//                 Instantiate(enemy, transform.position, Quaternion.identity);
//                 timer += 2;
//             //}
//         }
// 
//         // SpawnWave2();
//     }
// 
//     private void SpawnWave2()
//     {
//         foreach (GameObject enemy in arrayWave2)
//         {
//             if (timer <= 0)
//             {
//                 Instantiate(enemy, transform.position, Quaternion.identity);
//                 timer += 2;
//             }
//         }
// 
//         // SpawnWave1();
//     }
// 
//     //private void SpawnWave3()
//     //{
//     //    foreach (GameObject enemy in arrayWave3)
//     //    {
//     //        if (timer <= 0)
//     //        {
//     //            Instantiate(enemy, transform.position, Quaternion.identity);
//     //            timer += 2;
//     //        }
//     //    }
//     //
//     //    SpawnWave1();
//     //}
// 
// }
