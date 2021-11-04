using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [SerializeField] private float range = 8f;
    private Transform target;
    public Transform rotationPoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.3f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        float lowestDistance = Mathf.Infinity;
        GameObject closestEnemy = null;

        foreach (GameObject Enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, Enemy.transform.position);

            if (distanceToEnemy < lowestDistance)
            {
                lowestDistance = distanceToEnemy;
                closestEnemy = Enemy;
            }

            if (closestEnemy != null && distanceToEnemy <= range)
            {
                target = closestEnemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        rotationPoint.LookAt(new Vector3(target.position.x, rotationPoint.position.y, target.position.z));

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
