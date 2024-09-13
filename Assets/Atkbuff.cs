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
        PlayerBullet stats = FindAnyObjectByType<PlayerBullet>();
        stats._damageAmount *= multiplier;
        target.transform.localScale *= multiplier;



    }


}
