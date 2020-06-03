using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    private Rigidbody2D self;
    public float initForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        self = this.GetComponent<Rigidbody2D>();
        self.AddForce(transform.up * initForce);
        transform.parent = null;
    }
}
