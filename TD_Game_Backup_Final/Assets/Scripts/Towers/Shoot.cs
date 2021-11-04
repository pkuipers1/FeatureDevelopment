using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] public float maxCooldown;
    [SerializeField] private float currentCooldown;
    [SerializeField] private bool canShoot;

    private AudioSource source;

    private ParticleSystem[] particleSystems;
    private RangeChecker rangeChecker;

    public float turretDamage;

    private void Start()
    {
        particleSystems = GetComponentsInChildren<ParticleSystem>();
        rangeChecker = GetComponent<RangeChecker>();
        source = GetComponent<AudioSource>();
    }

    public void ShootBullet()
    {
        Enemy enemy = rangeChecker.GetFirstEnemyInRange();
        HealthScript healthScript = enemy.GetComponent<HealthScript>();

        currentCooldown -= Time.deltaTime;

        if (currentCooldown <= 0)
        {
            foreach (ParticleSystem particle in particleSystems)
            {
                particle.Play();
                source.Play();
            }

            healthScript.currentHealth -= turretDamage;

            currentCooldown += maxCooldown;
        }
    }

}
