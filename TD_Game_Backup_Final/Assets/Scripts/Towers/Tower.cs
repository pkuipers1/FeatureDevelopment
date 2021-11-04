using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RangeChecker))]

public class Tower : MonoBehaviour
{
    // Moet op enemies schieten wanneer ze in range zijn
    [SerializeField] private Transform turret;

    private RangeChecker rangeChecker;
    private Shoot shoot;

    // Start is called before the first frame update
    void Start()
    {
        rangeChecker = GetComponent<RangeChecker>();
        shoot = GetComponent<Shoot>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = rangeChecker.GetFirstEnemyInRange();

        if (enemy != null)
        {
            shoot.ShootBullet();

            turret.LookAt(enemy.transform);
        }
    }
}
