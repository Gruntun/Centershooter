using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ammo : MonoBehaviour
{


        private Slider ammobar;

        public Weapon2 wep;

    // Start is called before the first frame update
   
    private void Awake() {
      ammobar = GetComponent<Slider>(); 
   }

    // Update is called once per frame
    void Update()
    {
        ammobar.value = wep.ammo;
    }
}
