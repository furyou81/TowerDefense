using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;
    public float health = 100f;
    public int value = 50;
    public GameObject deathEffect;

    void Start() {
        speed = startSpeed;
    }

    public void TakeDamage(float amount) {
        health -= amount;

        if (health <= 0) {
            Die();
        }
    }

    public void Slow(float slowPct) {
        speed = startSpeed * (1f - slowPct);
    }

    void Die(){
        PlayerStats.Money += value;
        
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        
        Destroy(gameObject);
    }

}
