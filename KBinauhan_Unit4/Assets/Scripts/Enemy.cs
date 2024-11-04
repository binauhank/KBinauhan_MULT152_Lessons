using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody enemyRB;
    GameObject player;
    public float speed = 4.0f;

    private float yBoundary = -15.0f;
    
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRB = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (transform.position.y < yBoundary)
        {
            Destroy(gameObject);
        }
        Vector3 seekDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(seekDirection * speed * Time.deltaTime);
    }
}
