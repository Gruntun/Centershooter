using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;

    public Rigidbody2D rb;

    void FixedUpdate()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

  

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.tag);
    }
}
