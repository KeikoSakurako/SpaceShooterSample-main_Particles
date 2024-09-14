using UnityEngine;

public class PlayerShip : Ship, IShooter
{
    [Header("Shooting")]
    [SerializeField] private Projectile _bullet;
    public Projectile Projectile => _bullet;
    [SerializeField] private Transform[] _spawnPoints;
    public Transform[] SpawnPoints => _spawnPoints;

    //
    public bool activeup = false;

    public void Shoot(Vector2 upDirection)
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            //
            var bullet = Instantiate(_bullet, spawnPoint.position, Quaternion.identity).GetComponent<PlayerBullet>();

            if (activeup == true)
            {
                bullet.Intialize(this, 20f);
            }
            else
            {
                bullet.Intialize(this);
            }

            bullet.Move(upDirection);
        }
    }
}