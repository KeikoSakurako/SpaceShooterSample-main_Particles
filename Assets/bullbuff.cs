using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power/Bullet")]
public class bullbuff : BuffManager
{
    public float multiplier;


    public override void Apply(GameObject target)
    {
        PlayerShip stats = FindObjectOfType<PlayerShip>();
        stats._currentHealth *= multiplier;


    }
}
