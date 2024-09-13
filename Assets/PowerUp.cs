using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public BuffManager poweff;
    public float multiplier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        poweff.Apply(collision.gameObject);
        Destroy(gameObject);


    }



}
