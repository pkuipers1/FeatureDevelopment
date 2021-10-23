using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Op vijanden schieten wanneer ze in range zijn
[RequireComponent(typeof(EnemyInRangeChecker))]
public class Tower1 : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 15;
    [SerializeField] private float _shootCooldown = 0.5f;
    [SerializeField] private Transform _turret;
    
    private EnemyInRangeChecker _enemyInRangeChecker;
    private float _nextShootTime = 0;

    private void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();
    }

    private void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy != null)
        {
            _turret.LookAt(enemy.transform);
            if (CanShoot())
            {
                enemy.GetHealthComponent().TakeDamage(_damageAmount);
                _nextShootTime = Time.time + _shootCooldown;
            }
        }
    }

    private bool CanShoot()
    {
        return Time.time >= _nextShootTime;
    }
}
