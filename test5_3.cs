using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test5_3 : MonoBehaviour
{
    private NavMeshAgent navAgent;

    private float move_time = 10f;
    private float timer_cnt;


    [SerializeField] private GameObject goal;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();

    }

    private void Start()
    {
        timer_cnt = move_time;
    }

    private void Update()
    {
        //個々のポジションを秒ごとに変化させる
        navAgent.SetDestination(goal.transform.position);
    }
}
