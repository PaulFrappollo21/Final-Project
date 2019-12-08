using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{ 
    
    public float speed = 8f;
    public Rigidbody2D rb;
    public AudioSource enemy;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Destroy(gameObject);
        }
      
        else if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            enemy.Play();
         
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(gameObject);
        }
    }
}
