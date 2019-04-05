using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlTwo : MonoBehaviour
{
    public float speed;

    public float slowdownspeed;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
rb.AddForce (-Vector2.right * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.RightArrow)) {
rb.AddForce (Vector2.right * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.DownArrow)) {
rb.AddForce (-Vector2.up * speed * Time.deltaTime);
}
if (Input.GetKey (KeyCode.UpArrow)) {
rb.AddForce (Vector2.up * speed * Time.deltaTime);
}


slowdown();
    }

    void slowdown(){

        rb.velocity = rb.velocity * new Vector2(slowdownspeed, slowdownspeed);

    }
}
