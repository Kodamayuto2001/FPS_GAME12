using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota_test4 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }
}
