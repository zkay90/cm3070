using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    private float coolDown = 0.0f;
    public float fireRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coolDown > 0.0f)
        {
            coolDown -= Time.deltaTime;
        } else
        {
            shoot();
        }
    }

    void shoot()
    {
        if (coolDown <= 0.0f)
        {
            coolDown = fireRate;

            GameObject o = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), bulletPrefab.transform.rotation);
        }
    }
}
