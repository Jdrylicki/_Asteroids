using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMover : MonoBehaviour

{
    public float bulletSpeed = 5f;
    public Rigidbody2D rb;

    // Update is called once per frame
    private void Start()
    {
        rb.velocity = transform.up * bulletSpeed;
    }
}
