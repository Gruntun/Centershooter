using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float slowdownspeed;

    public Rigidbody2D rb;

   
    void Update()
    {
       if (Input.GetKey (KeyCode.A)) {
rb.AddForce (-Vector2.right * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.D)) {
rb.AddForce (Vector2.right * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.S)) {
rb.AddForce (-Vector2.up * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.W)) {
rb.AddForce (Vector2.up * speed * Time.deltaTime);
}


slowdown();
    }

    void slowdown(){

        rb.velocity = rb.velocity * new Vector2(slowdownspeed, slowdownspeed);

    }


}
