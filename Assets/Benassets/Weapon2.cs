using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform center;
    public float fireRate;
    private float nextTimeToFire = 0f;
    

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = center.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Input.GetKey(KeyCode.RightShift) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }


    }


    void Shoot()
    {
        GameObject bulletInstance;

        bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);



        bulletInstance.GetComponent<bullet>().MainPlayer = transform;

    }
}
