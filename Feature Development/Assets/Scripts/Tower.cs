using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RangeChecker))]

public class Tower : MonoBehaviour
{
    // Moet op enemies schieten wanneer ze in range zijn
    [SerializeField] private Transform turret;
    private RangeChecker rangeChecker;

    // Start is called before the first frame update
    void Start()
    {
        rangeChecker = GetComponent<RangeChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = rangeChecker.GetFirstEnemyInRange();

        if (enemy != null)
        {
            turret.LookAt(enemy.transform);
            Debug.Log(enemy.name);
        }
    }
}
