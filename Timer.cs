using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float time = 0.0f;
    [SerializeField]
    public int secondsElapsed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            secondsElapsed += 1;
            time = 0;
        }

        
    }
}
