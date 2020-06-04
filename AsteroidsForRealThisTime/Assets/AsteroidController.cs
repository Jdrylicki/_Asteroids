using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float maxForce = 10f;
    public float minForce = 1f;
    public float Spin = 0f;
    public float initRot = 0f;
    private float spinSpeed;
    public Vector2 initDisp = new Vector2(0, 0);
    public float left, right, lower, upper;

    // Start is called before the first frame update
    void Start()
    {
        float initForce = Random.Range(minForce, maxForce);
        spinSpeed = Random.Range(-Spin, Spin);
        transform.localPosition.Set(initDisp.x, initDisp.y, 0);

        if (initRot != 0)
        {
            transform.Rotate(0, 0, initRot);
        } else
        {
            transform.Rotate(0, 0, spinSpeed * 20);
        }
        
        
        Rigidbody2D tempAsteroid = this.GetComponent<Rigidbody2D>();
        tempAsteroid.AddForce(transform.up * initForce);
    }

    void Update()
    {
        if (transform.parent != null)
        {
            transform.parent = null;
        }


    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, spinSpeed);
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
