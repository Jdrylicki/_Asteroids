using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Transform Player;
    public float minPlayerDistance = 5f;
    private float nextSpawn;
    public float leftBound = -5f;
    public float rightBound = 5f;
    public float upperBound = 5f;
    public float lowerBound = -5f;
    public float cooldownTimer = 5f;
    public GameObject asteroid;

    // Update is called once per frame
    void Update()
    { 
        if (!onCoolDown())
        {
            transform.position = getRandomPos(leftBound, rightBound, lowerBound, upperBound);

            if (!nearPlayer())
            {
                nextSpawn = cooldownTimer + Time.time;
                Spawn();
            }
        }
    }

    private bool onCoolDown()
    {
        return nextSpawn >= Time.time;
    }

    private bool nearPlayer()
    {
        return ((transform.position - Player.position).magnitude <= minPlayerDistance);
    }

    public Vector3 getRandomPos(float left, float right, float upper, float lower)
    {
        float newX = Random.Range(left, right);
        float newY = Random.Range(lower, upper);
        Vector3 newPos = new Vector3(newX, newY,0);
        return newPos;
    }

    public void Spawn()
    { 
        GameObject newAsteroid;
        newAsteroid = Instantiate(asteroid, transform) as GameObject;
    }
}
