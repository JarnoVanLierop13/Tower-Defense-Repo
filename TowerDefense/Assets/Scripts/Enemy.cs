using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    // link niet naar playerData maar naar de playerData van GameManagerNew script
    public PlayerData playerData;
    

    private Transform target;
    private int waypointIndex = 0;
    public int enemyHP;
    

    private void Start()
    {
        // references en eerste waypoint aangegeven
        target = WayPoints.locations[0];
        GameObject gameManagerObj = GameObject.Find("Managers/GameManager");
        GameManagerNew gameManagerNew = gameManagerObj.GetComponent<GameManagerNew>();
        playerData = gameManagerNew.playerData;
    }

    private void Update()
    {
        EnemyDead();
        // movement richting waypoint
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
            EnemyIncoming(); // als een enemy het einde bereikt
            return;
        }

        waypointIndex++;
        target = WayPoints.locations[waypointIndex];
    }

    private void EnemyDead()
    {
        if (enemyHP <= 0)
        {
            playerData.GivePoints(50);
            Destroy(gameObject);
        }
    }

    private void EnemyIncoming()
    {
        playerData.EnemyReachedEnd();
        Destroy(gameObject);
    }
    
}