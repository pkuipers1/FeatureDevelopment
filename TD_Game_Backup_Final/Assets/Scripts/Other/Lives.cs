using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public GameObject[] heartArray;

    public void RemoveHeart()
    {
        heartArray = GameObject.FindGameObjectsWithTag("Heart");

        if (heartArray.Length <= 1)
        {
            SceneManager.LoadScene("Death");
        }

        else
        {
            GameObject firstHeart = heartArray[0];

            Destroy(firstHeart);

            heartArray = GameObject.FindGameObjectsWithTag("Heart");
        }
    }
}
