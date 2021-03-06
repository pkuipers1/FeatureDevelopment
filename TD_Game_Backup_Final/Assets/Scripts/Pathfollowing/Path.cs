using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;

    // [SerializeField] private Waypoint[] lowerSpawn;
    // [SerializeField] private Waypoint[] topSpawn;
    // 
    // [SerializeField] private Waypoint[] topRoute;
    // [SerializeField] private Waypoint[] lowerRoute;
    // 
    // [SerializeField] private Waypoint[] topEnd;
    // [SerializeField] private Waypoint[] lowerEnd;



    public Waypoint GetPathStart()
    {
        return _waypoints[0];
    }

    public Waypoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }

    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        for (int i = 0; i < _waypoints.Length; i++)
        {
            if (_waypoints[i] == currentWaypoint)
            {
                return _waypoints[i + 1];
            }
        }
        return null;
    }
}
