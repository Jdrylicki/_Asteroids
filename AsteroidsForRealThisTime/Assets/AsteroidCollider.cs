using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollider : MonoBehaviour
{
    public GameObject child;
    public float[] childRot = new float[3];
    public Vector3[] childPos;
    public float childScale;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag.Equals("Laser"))
        {
            Destroy();
        }
        
        /* I need to figure out a way to make this not crash unity lmao
         * 
         * 
         * 
         * if (collision.collider.tag.Equals("Asteroid"))
        {
            Transform tempTransform = transform;
            Destroy();
            GameObject asteroid1 = Instantiate(child, childPos[0], Quaternion.Euler(0, 0, childRot[0]), tempTransform);
            asteroid1.transform.sc .Set(childScale,childScale,1);
            GameObject asteroid2 = Instantiate(child, childPos[1], Quaternion.Euler(0, 0, childRot[1]), tempTransform);
            asteroid2.transform.localScale.Set(childScale, childScale, 1);
            GameObject asteroid3 = Instantiate(child, childPos[2], Quaternion.Euler(0, 0, childRot[2]), tempTransform);
            asteroid3.transform.localScale.Set(childScale, childScale, 1);

            // instantiate 3 asteroids
            // set each Asteroid
        }
        */
    }


    void Destroy()
    {
        Destroy(this.gameObject);
    }

}
