using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropChance : MonoBehaviour
{
    public GameObject[] dropItemPre;
    public float dropchange;
    private Rigidbody2D rb;
    
    public void DropChance1(Vector3 spawntion)
    {
        if(Random.Range(0f, 100f) <= dropchange)
        {
            var power = Instantiate(dropItemPre[Random.Range(0, dropItemPre.Length)], spawntion, Quaternion.identity).GetComponent<PowerUp>();
            
            float dropForce = 1f;
            Vector2 dropDir = new Vector2(Random.Range(-1f, 1), Random.Range(-1f, 1));
            power.GetComponent<Rigidbody2D>().AddForce(dropDir * dropForce, ForceMode2D.Impulse);
            rb = GetComponent<Rigidbody2D>();
        }

    }
}
