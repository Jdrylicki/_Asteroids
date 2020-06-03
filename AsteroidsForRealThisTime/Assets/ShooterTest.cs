using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTest : MonoBehaviour
{
    public GameObject Laser;
    public Transform bulletSpawner;
    private float nextShot;
    public float cooldownTimer = 2f;
    public float bulletDeathTimer = 5f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire1") && !onCoolDown())
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        nextShot = Time.time + cooldownTimer;
        GameObject newLaser;
        newLaser = Instantiate(Laser, bulletSpawner) as GameObject;
        Destroy(newLaser, bulletDeathTimer);
    }

    public bool onCoolDown()
    {
        return nextShot >= Time.time;
    }
}
