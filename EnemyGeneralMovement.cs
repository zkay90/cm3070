using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneralMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
