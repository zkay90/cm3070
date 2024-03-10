using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public int health = 100;

    private float negXBound = -14.5f;
    private float posXBound = 14.4f;
    private float negZBound = -10.0f;
    private float posZBound = 5.8f;

    private float horizontalInput;
    private float verticalInput;

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check bounds
        if(transform.position.x < negXBound)
        {
            transform.position = new Vector3(negXBound, transform.position.y, transform.position.z);
        }
        if(transform.position.x > posXBound)
        {
            transform.position = new Vector3(posXBound, transform.position.y, transform.position.z);
        }
        if(transform.position.z < negZBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, negZBound);
        }
        if(transform.position.z > posZBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, posZBound);
        }
        //Movement
        horizontalInput = Input.GetAxis("Horizontal");
       // transform.Rotate(Vector3.forward, horizontalInput * speed);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
       Debug.Log("Player collided with: " + other.gameObject.tag);
        GameObject o = other.gameObject;
        if(o != null)
        {
            if(o.CompareTag("Enemy1") || o.CompareTag("Enemy2") || o.CompareTag("Enemy3"))
            {
                takeDamage(o.GetComponent<EnemyHealth>().dealsDamage);
            }

            if(o.CompareTag("EnemyBullet"))
            {
                takeDamage(o.GetComponent<BulletMovement>().damage);
                Destroy(other.gameObject);
            }
            
        }
        
    }

    //Damage
    void takeDamage(int damage)
    {
        health -= damage;
        if(health < 0)
        {
            gameOver();
        }
    }

    void gameOver()
    {
        Time.timeScale = 0.0f;
        AudioListener.pause = true;
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameOver>().displayText();
    }

}
