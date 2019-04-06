using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform center;
    public float fireRate;
    private float nextTimeToFire = 0f;
    public int ammo;
    public float reloadtime;
    int maxammo;


    private void Start()
    {
        maxammo = ammo;
    }


    // Update is called once per frame
    void Update()
    {

        Vector3 dir = center.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Input.GetKey(KeyCode.LeftShift) && Time.time >= nextTimeToFire && ammo > 0)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
        }


        if( ammo <= 0)
        {
            StartCoroutine(Reload());
        }

    }


    void Shoot()
    {
        ammo -= 1;
        GameObject bulletInstance;

       bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

       

                  bulletInstance.GetComponent<bullet>().MainPlayer = transform;

    }

    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadtime);

        ammo = maxammo;
    }
}
