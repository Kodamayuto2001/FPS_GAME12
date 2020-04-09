using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav_rota : MonoBehaviour
{
    NavMeshSurface a;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        a.BuildNavMesh();
    }
}
