using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    PlayerHealth health;
    // Start is called before the first frame update
    void Start()
    {
       health = gameObject.GetComponent<PlayerHealth>(); 
    }

    // Update is called once per frame
    void Update()
    {
     

        if (health.Health <= 0)
        {
            Debug.Log("I AM DEAD!");

            Destroy(gameObject);
        }
    }
}
