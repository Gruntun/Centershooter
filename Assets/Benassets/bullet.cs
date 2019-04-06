using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;

    public Rigidbody2D rb;

    public Transform MainPlayer;

    public int damage;

    Transform REALPLAYER;

    GameObject THEONETRUEPLAYER;

    void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;

       

      

        
    


    }

  

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (hitInfo.gameObject != MainPlayer.root.gameObject)
        {
            if (playerHealth != null)
            {
                playerHealth.takeDamage(damage);
            }
                
            Destroy(gameObject);

             Debug.Log(MainPlayer.root);
        }
        
    }
}
