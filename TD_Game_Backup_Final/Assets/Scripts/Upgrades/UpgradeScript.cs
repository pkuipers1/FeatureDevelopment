using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public GameObject turretType02;
    public GameObject turretType03;
    public GameObject turretType04;

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
                if (hit.transform.tag == "Level1" && currencyScript.currentCoins >= 100)
                {
                    float turretPlacePointX = hit.transform.position.x;
                    float turretPlacePointY = hit.transform.position.y;
                    float turretPlacePointZ = hit.transform.position.z;


                    Vector3 turretBuildLocation = new Vector3(turretPlacePointX, turretPlacePointY, turretPlacePointZ);

                    Destroy(hit.transform.gameObject);

                    Instantiate(turretType02, turretBuildLocation, Quaternion.identity);

                    currencyScript.currentCoins -= 100;
                }

                if (hit.transform.tag == "Level2" && currencyScript.currentCoins >= 300)
                {
                    float turretPlacePointX = hit.transform.position.x;
                    float turretPlacePointY = hit.transform.position.y;
                    float turretPlacePointZ = hit.transform.position.z;


                    Vector3 turretBuildLocation = new Vector3(turretPlacePointX, turretPlacePointY, turretPlacePointZ);

                    Destroy(hit.transform.gameObject);

                    Instantiate(turretType03, turretBuildLocation, Quaternion.identity);

                    currencyScript.currentCoins -= 300;
                }

                if (hit.transform.tag == "Level3" && currencyScript.currentCoins >= 200)
                {
                    float turretPlacePointX = hit.transform.position.x;
                    float turretPlacePointY = hit.transform.position.y;
                    float turretPlacePointZ = hit.transform.position.z;


                    Vector3 turretBuildLocation = new Vector3(turretPlacePointX, turretPlacePointY, turretPlacePointZ);

                    Destroy(hit.transform.gameObject);

                    Instantiate(turretType04, turretBuildLocation, Quaternion.identity);

                    currencyScript.currentCoins -= 200;
                }
            }
        }
    }
}
