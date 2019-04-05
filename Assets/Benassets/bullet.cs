using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;

    public Rigidbody2D rb;

    public Transform MainPlayer;

    Transform REALPLAYER;

    GameObject THEONETRUEPLAYER;

    void Update()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;

       

      

        
    


    }

  

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Attributes atrri = hitInfo.GetComponent<Attributes>();
        if (hitInfo.gameObject != MainPlayer.root.gameObject)
        {
            if (hitInfo.tag == "Player")
            {
                atrri.takeDamage(30);

               
            }
                
            Destroy(gameObject);

             Debug.Log(MainPlayer.root);
        }
        
    }
}
