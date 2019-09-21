using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ennemy))]
public class EnnemyMovement : MonoBehaviour
{
    private Transform target;
    private int wavepointIndex = 0;
    private Ennemy ennemy;

    void Start() {
        ennemy = GetComponent<Ennemy>();
        target = WayPoints.points[0];
    }

    void Update() {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * ennemy.speed * Time.deltaTime, Space.World);    
    
        if (Vector3.Distance(transform.position, target.position) <= 0.2f) {
            GetNextWayPoint();
        }

        ennemy.speed = ennemy.startSpeed;
    }

    void GetNextWayPoint() {
        if (wavepointIndex >= WayPoints.points.Length - 1) {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WayPoints.points[wavepointIndex];
    }

    void EndPath() {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
