using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthbarController1 : MonoBehaviour
{

    private Slider healthBar;

    public PlayerHealth ph;

   
    // Start is called before the first frame update


     private void Awake() {

        healthBar = GetComponent<Slider>();
        
    }
  

    // Update is called once per frame
    void Update()
    {
         healthBar.value = ph.Health;
    }

    
}
