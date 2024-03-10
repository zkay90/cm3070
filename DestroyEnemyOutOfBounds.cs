using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyOutOfBounds : MonoBehaviour
{
    private float lowerBound = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
