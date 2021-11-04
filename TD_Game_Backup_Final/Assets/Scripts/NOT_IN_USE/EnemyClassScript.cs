using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClassScript
{
    private float baseHealth;
    private float armorModifier;

    public float enemyLife;

    public EnemyClassScript(float health, float armor)
    {
        baseHealth = health;
        armorModifier = armor;
    }

    public float calculateEnemyLife()
    {
        enemyLife = baseHealth * armorModifier;

        return enemyLife;
    }
}
