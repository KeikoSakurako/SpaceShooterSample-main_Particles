using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power/Spd")]
public class SpdBuff : BuffManager
{
    public float multiplier;
    [SerializeField] Rigidbody2D rb;


   

    public override void Apply(GameObject target)
    {
        PlayerBullet bullet = target.GetComponent<PlayerBullet>();
        
        PlayerShip stats = bullet.Ship;
        stats._movementSpeed *= multiplier;
        //target.transform.localScale *= multiplier;



    }
}
