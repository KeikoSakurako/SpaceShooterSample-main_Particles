using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullspawnhell : MonoBehaviour
{
    enum SpawnType {Straight, spin }

    [Header("Bullet Attribute")]
    public GameObject bullet;
    public float bulletlife = 1f;
    public float spd = 1f;

    [Header("Spawner Attributes")]
    [SerializeField] private SpawnType spawnertype;
    [SerializeField] private float firingRate = 1f;


    private GameObject spawnBullet;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if(spawnertype == SpawnType.spin)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);



        }

        if(timer >= firingRate)
        {
            Fire();
            timer = 0f;
        }

    }

    private void Fire()
    {
        if(bullet)
        {
            spawnBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnBullet.GetComponent<EnemyBullet>().spd = spd;
            spawnBullet.GetComponent<EnemyBullet>().bulletLife = bulletlife;
            spawnBullet.transform.rotation = transform.rotation;
                  
        }

    }


}
