using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public GameObject spawnPoint;
    public GameObject bullet;
    public float fireRate = 5f;

    private float nextShot;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }




    public bool onCoolDown()
    {
        return nextShot >= Time.time;
    }

    public void shoot()
    {
        if (!onCoolDown())
        {
            nextShot = Time.time + fireRate;
            GameObject newBullet;
            newBullet = Instantiate(bullet,transform.position, transform.rotation);
            
        }
    }

}





