using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai1 : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Vector3 basePos;
    //回転スピード
    [SerializeField]
    private float rotateSpeed = 45f;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        basePos = transform.position;
    }

    private void Update()
    {
        transform.position = basePos + new Vector3(Mathf.Sin(Time.time) * 3f, 0f, 0f);
    }

}
