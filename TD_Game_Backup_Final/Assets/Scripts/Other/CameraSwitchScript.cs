using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScript : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    [SerializeField] public GameObject currentCam;

    void Start()
    {
        currentCam = cam1;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (currentCam == cam1)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                currentCam = cam2;
            }
            else
            {
                cam2.SetActive(false);
                cam1.SetActive(true);
                currentCam = cam1;
            }
        }
    }
}
