using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;

    public Rigidbody2D rb;

    public GameObject enemyPlayer;

    void FixedUpdate()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

  

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        {
            enemyPlayer.TakeDamage(30);
            
        }
        Destroy(gameObject);
    }
}
