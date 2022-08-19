using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour
{
    [SerializeField] private float seekTimeInterval = 2.0f;
    [SerializeField] private float seekTimeThreshold = 0.0f;

    [SerializeField] private Transform target;

    // seekTime interval between player tracking updates
    private float seekTime = 0.0f;
    NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        seekTime -= Time.deltaTime;

        if (seekTime <= seekTimeThreshold)
        {
            seekTime = seekTimeInterval;

            navAgent.SetDestination(target.position);

        }
    }
}
