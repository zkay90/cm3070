using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 5;

    //Amount of damage which is dealt to player on collission
    public int dealsDamage = 5;

    //Get reference to the points system
    Points ptsSystem;

    void Start()
    {
        ptsSystem = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Points>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 1) 
        {
            destroyEnemy();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            //Debug.Log("C: " + other.gameObject.tag);
            //
            Debug.Log("Hit");
            health -= other.gameObject.GetComponent<BulletMovement>().damage;
            Destroy(other.gameObject);

            ptsSystem.addPoints(2);
        }

        //Check to see if enemy got hit with player or with bullet.
        if (other.gameObject.transform.parent.parent.CompareTag("Player"))
        {
            
            destroyEnemy();
        }       
        
    }

    void destroyEnemy()
    {
        ptsSystem.addPoints(5);
        Destroy(gameObject);
    }

}
