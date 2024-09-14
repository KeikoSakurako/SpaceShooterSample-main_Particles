using UnityEngine;

public class PlayerBullet : Projectile
{
    //Reference for the ship
    public PlayerShip Ship;
    public Projectile Projectile;

    //To iN
    public void Intialize(PlayerShip ship)
    {
        Ship = ship;
    }
    public void Intialize(PlayerShip ship,float damage)
    {
        Ship = ship;
        _damageAmount = damage;
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }
}