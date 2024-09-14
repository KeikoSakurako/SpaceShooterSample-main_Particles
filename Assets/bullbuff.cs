using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power/Bullet")]
public class bullbuff : BuffManager
{
    public float multiplier;


    public override void Apply(GameObject target)
    {
        PlayerBullet bullet = target.GetComponent<PlayerBullet>();
        PlayerShip stats = bullet.Ship;
        stats._currentHealth *= multiplier;

    }
}
