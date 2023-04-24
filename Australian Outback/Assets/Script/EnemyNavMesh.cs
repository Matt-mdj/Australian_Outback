using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject player;

    Transform target;

    private void Start()
    {
        player = GameObject.FindWithTag("House");
        target = player.transform;
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        agent.destination = target.position;
    }
}