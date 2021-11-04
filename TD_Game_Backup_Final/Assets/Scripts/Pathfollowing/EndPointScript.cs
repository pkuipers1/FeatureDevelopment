using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointScript : MonoBehaviour
{
    public Lives lives;

    private void Start()
    {
        lives = GameObject.Find("HeartPanel").GetComponent<Lives>();
    }

    private void OnTriggerEnter(Collider other)
    {
        lives.RemoveHeart();

        Destroy(other);
    }
}
