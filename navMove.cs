using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMove : MonoBehaviour
{
    [SerializeField]
    private Transform goal;

    [SerializeField]
    private Vector3 judge = new Vector3(2f, 2f, 2f);

    NavMeshAgent agent;

    
    private Vector3[] pos;
    private Vector3 CarrentPos;

    private int cnt = 0;

    private Vector3[] distance;
    private Vector3 distance_ave;
    private Vector3 distance_sum;
    private Vector3 startPos;
    private void Start()
    {
        startPos = this.transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        
    }
    //5秒間の距離の平均値が、小さすぎるのであるならば、そこはもういけないと判断してもよい
    //transform.rotation = Quaternion.Euler(0, 90f, 0); 
    private void Update()
    {
        CarrentPos = this.transform.position;
        Calc();
        if (distance_ave.x < judge.x) {
            agent.destination = startPos;
        }
        if (distance_ave.y < judge.y) {
            
        }
        if (distance_ave.z < judge.z) {
            agent.destination = startPos;
        }

    }

    private void FixedUpdate()
    {
        //FixedUpdateの呼ばれる秒数を0.5秒にするEdit->Project Setting Time
        pos[cnt % 10] = this.transform.position;
        cnt++;
    }

    private void Calc()
    {
        for (int i = 0; i < 10; i++)
        {
            if (Mathf.Abs(CarrentPos.x) > Mathf.Abs(pos[i].x)) { distance[i].x = Mathf.Abs(CarrentPos.x) - Mathf.Abs(pos[i].x); }
            else { distance[i].x = Mathf.Abs(pos[i].x) - Mathf.Abs(CarrentPos.x); }
            if (Mathf.Abs(CarrentPos.y) > Mathf.Abs(pos[i].y)) { distance[i].y = Mathf.Abs(CarrentPos.y) - Mathf.Abs(pos[i].y); }
            else { distance[i].y = Mathf.Abs(pos[i].y) - Mathf.Abs(CarrentPos.y); }
            if (Mathf.Abs(CarrentPos.z) > Mathf.Abs(pos[i].z)) { distance[i].z = Mathf.Abs(CarrentPos.z) - Mathf.Abs(pos[i].z); }
            else { distance[i].z = Mathf.Abs(pos[i].z) - Mathf.Abs(CarrentPos.z); }
        }
        for (int i = 0; i < 10; i++)
        {
            distance_sum += distance[i];
        }
        distance_ave = distance_sum / 10;
    }

}