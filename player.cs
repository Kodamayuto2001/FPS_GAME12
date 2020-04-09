using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class player : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField] private Transform goal;

    private int cnt = 0;

    [SerializeField]private Transform[] subgoal;

    [SerializeField] private Transform kaiten;

    private int i = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    private void Update()
    {
        if (cnt > 20)
        {
            agent.destination = subgoal[0].position;
        }

        if (cnt > 40)
        {
            agent.destination = goal.position;
        }
    }


    private void FixedUpdate()
    {
        //0.5秒ずつ
        cnt++;
    }
}

