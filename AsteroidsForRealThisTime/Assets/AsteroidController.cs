using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float maxForce = 10f;
    public float minForce = 1f;
    public float Spin = 0f;
    float initRot;
    public float left, right, lower, upper;

    // Start is called before the first frame update
    void Start()
    {
        float initForce = Random.Range(minForce, maxForce);
        initRot = Random.Range(-Spin, Spin);
        transform.parent = null;
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        Vector2 vel = new Vector2(x, y);
        vel.Normalize();
        Rigidbody2D tempAsteroid = this.GetComponent<Rigidbody2D>();
        tempAsteroid.AddForce(vel * initForce);
    }

    void Update()
    {
        


    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, initRot);
        Remove();

    }

    void Remove()
    {
        if (transform.position.x <= left || transform.position.x >= right ||
            transform.position.y <= lower || transform.position.y >= upper)
        {
            Destroy(this.gameObject);
        }
    }
}
