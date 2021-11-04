using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFolloer : MonoBehaviour
{
    // Beeegt langs een path

    [SerializeField] private float _speed;
    [SerializeField] float _arrivalThreshold;
    
    private Path _path;
    public Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }

    // private void GoToNext()
    // {
    //     transform.LookAt(_currentWaypoint.GetPosition());
    //     transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    // }

    private void Update()
    {
        transform.LookAt(_currentWaypoint.GetPosition());
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float distanceToAypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());

        if ( distanceToAypoint <= _arrivalThreshold)
        {
            if ( _currentWaypoint == _path.GetPathEnd())
            {

            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());

            }
        }

        // IF afstand tussen blokje en aypoint <= arrivalthreshold, currentaypoint is volgend aypoint
    }

    private void PathComplete()
    {

    }
}
