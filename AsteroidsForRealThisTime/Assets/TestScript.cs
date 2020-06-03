using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float Spin = 0f;
    float initRot;

    void Start()
    {
        initRot = Random.Range(-Spin, Spin);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, initRot);
    }

}
