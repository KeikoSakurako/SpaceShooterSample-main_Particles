using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossPatrol : MonoBehaviour
{
    public GameObject[] points;
    private int pointIndex;

    public float spd;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointIndex <= points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].transform.position, spd * Time.deltaTime);

        }
        
        if(transform.position == points[pointIndex].transform.position)
        {
            pointIndex += 1;
        }

        if(pointIndex == points.Length)
        {
            pointIndex = 0;
        }

    }
}
