using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power/Spd")]
public class SpdBuff : BuffManager
{
    public float multiplier;


    public override void Apply(GameObject target)
    {
        PlayerShip stats = FindAnyObjectByType<PlayerShip>();
        stats._movementSpeed *= multiplier;
        //target.transform.localScale *= multiplier;



    }
}
