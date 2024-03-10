using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    public GameObject bulletPrefab;

    private float fireRate = 0.0f;

    private AudioSource gunAudio;
    // Start is called before the first frame update
    void Start()
    {
        gunAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update the firing rate timer
        if (fireRate > 0.0f)
        {
            fireRate -= Time.deltaTime;
        }

        //Shooting
        if (Input.GetKey(KeyCode.Space))
        {
            shoot();
        }
    }

    //Shooting function
    void shoot()
    {

        if(fireRate <= 0.0f)
        {
            fireRate = 0.2f;
            //GameObject o = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            GameObject o = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 3), bulletPrefab.transform.rotation);

            //play the gunshot sound
            gunAudio.PlayOneShot(gunAudio.clip);

        }
        
    }
}
