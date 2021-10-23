using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeChecker : MonoBehaviour
{
    // Checkt of er iets in range is

    [SerializeField] private float radius;
    [SerializeField] private LayerMask layer;

    public Enemy GetFirstEnemyInRange()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, layer);

        if(colliders.Length <= 0)
        {
            return null;
        }

        return colliders[0].GetComponent<Enemy>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
