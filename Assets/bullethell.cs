using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullethell : MonoBehaviour
{
    public float bulletLife = 1f;

    public float rotation = 0f;
    public float spd = 4f;

    private Vector2 spawnPoint;
    private float timer = 0f;

    private void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }

    private void Update()
    {
        if (timer > bulletLife) Destroy(this.gameObject);
        timer += Time.deltaTime;
        transform.position = Movement(timer);


    }

    private Vector2 Movement(float timer)
    {
        float x = timer * spd * transform.right.x;
        float y = timer * spd * transform.right.y;
        return new Vector2(x + spawnPoint.x, y + spawnPoint.y);

    }

}
