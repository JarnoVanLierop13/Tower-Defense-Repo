using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

   public PlayerData playerData = new PlayerData();

    private Transform target;
    private int waypointIndex = 0;

    private void Start()
    {
        target = WayPoints.locations[0];
    }

    private void Update()
    {
        Vector3 directionTowardsNextWayPoint = target.position - transform.position;
        transform.Translate(directionTowardsNextWayPoint.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.05f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (waypointIndex >= WayPoints.locations.Length - 1)
        {
            EnemyIncoming();
            return;
        }

        waypointIndex++;
        target = WayPoints.locations[waypointIndex];
    }

    private void EnemyIncoming()
    {
        playerData.EnemyReachedEnd();
        Destroy(gameObject);
    }
    
}