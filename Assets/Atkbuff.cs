using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power/Atk")]
public class Atkbuff : BuffManager
{
    public float multiplier;
    //public float dura = 5;

    public override void Apply(GameObject target)
    {
        PlayerBullet bullet = target.GetComponent<PlayerBullet>();
        Projectile stats = bullet.Projectile;
        stats._damageAmount *= multiplier;
        Debug.Log(stats);
        target.transform.localScale *= multiplier;



    }


}
