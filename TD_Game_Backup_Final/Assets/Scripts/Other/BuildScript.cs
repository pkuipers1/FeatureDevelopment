using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    public GameObject turretType01;

    public CameraSwitchScript cameraSwitchScript;
    public CurrencyScript currencyScript;

    public Camera currentCamera;

    private void Start()
    {
        cameraSwitchScript = GameObject.Find("Main").GetComponent<CameraSwitchScript>();
        currencyScript = GameObject.Find("CoinAmount").GetComponent<CurrencyScript>();
    }

    void Update()
    {
        currentCamera = cameraSwitchScript.currentCam.GetComponent<Camera>();


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = currentCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                //Check if buildable and place turret   
                if (hit.transform.tag == "Buildable" && currencyScript.currentCoins >= 50)
                {
                    float turretPlacePointX = hit.transform.position.x;
                    float turretPlacePointY = hit.transform.position.y;
                    float turretPlacePointZ = hit.transform.position.z;


                    Vector3 turretBuildLocation = new Vector3(turretPlacePointX, turretPlacePointY, turretPlacePointZ);

                    Destroy(hit.transform.gameObject);

                    Instantiate(turretType01, turretBuildLocation, Quaternion.identity);

                    currencyScript.currentCoins -= 50;
                }
            }
        }
    }
}
