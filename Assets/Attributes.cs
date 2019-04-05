using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{

    public float health;

    private int selectedWeapon;

    public float energy;

    // Start is called before the first frame update
    void Start()
    {
        selectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void selectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
            

                weapon.gameObject.SetActive(true);

            
            else
            
                weapon.gameObject.SetActive(false);
                i++;
            
            
        }
                
    }

    public void takeDamage(int damage)
    {

    }

}
