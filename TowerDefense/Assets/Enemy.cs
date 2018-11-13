using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    private Transform target;
    private int waypointIndex = 0;

    private void Start()
    {
        target = WayPoints.locations[0];
    }

    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (waypointIndex >= WayPoints.locations.Length - 1)
        {
            EnemyDeath();
        }

        waypointIndex++;
        target = WayPoints.locations[waypointIndex];
    }

    private void EnemyDeath()
    {
        Destroy(gameObject);
        return;
    }

}
