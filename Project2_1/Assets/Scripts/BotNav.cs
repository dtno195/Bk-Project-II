﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotNav : MonoBehaviour {

    public float deathDistance = 2f;//toc do chay cua doi tuong
    public float distanceAway;
    public Transform thisObject;
    public Transform target;
    private GameObject BotLookAtPlayer;
    private NavMeshAgent navComponent;

    void Start()
    {
        thisObject = GameObject.FindGameObjectWithTag("Target").transform;
        target = GameObject.FindGameObjectWithTag("Parking").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            navComponent.SetDestination(target.position);
        }
        else
        {
            if (target == null)
            {
                target = this.gameObject.GetComponent<Transform>();
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
        if (dist <= deathDistance)
        {

        }
    }
}
