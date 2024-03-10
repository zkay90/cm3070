using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float upperBound = 7.0f;
    private float lowerBound = -11.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
