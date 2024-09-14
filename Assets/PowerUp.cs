using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public BuffManager poweff;
    public float multiplier;

    [SerializeField] Rigidbody2D rb;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        poweff.Apply(collision.attachedRigidbody.gameObject);
        print(collision.attachedRigidbody.gameObject);
        Destroy(gameObject);


    }



}
