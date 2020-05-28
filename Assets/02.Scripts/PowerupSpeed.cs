﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PowerupSpeed : MonoBehaviour
{
    NavMeshAgent nav;
    string playerTag = "Player";
    string obstacleTag = "Obstacle";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == obstacleTag)
        {
            transform.position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
        }
        if (other.tag == playerTag)
        {
            nav = other.gameObject.GetComponent<NavMeshAgent>();
            nav.speed += 1;
            transform.parent = other.transform;
            transform.localPosition = Vector3.up * 5;
            Destroy(gameObject, 1f);
        }
    }
}
