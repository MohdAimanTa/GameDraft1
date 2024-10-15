using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Randomspawner : MonoBehaviour
{
    public GameObject ItemPreFab;
    public float Radius = 1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObjectAtRandom();
        }
    }  
    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        Instantiate(ItemPreFab, randomPos, Quaternion.identity);
    }
    private void OnDrawGizmos()
    {
       Gizmos.color = Color.green;
       Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
