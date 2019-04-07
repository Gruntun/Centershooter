using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo2 : MonoBehaviour
{

     private Slider ammobar;

    public Weapon wep;

     private void Awake() {
      ammobar = GetComponent<Slider>(); 
   }

    // Update is called once per frame
    void Update()
    {
                ammobar.value = wep.ammo;

    }
}
