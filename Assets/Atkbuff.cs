using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atkbuff : MonoBehaviour
{
	public float multiplier = 1.5f;
	public float dura = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.CompareTag("Bullet"))
		{
			StartCoroutine(Pickup(collision));
		}
	}

 







    IEnumerator Pickup(Collider2D player)
    {
		player.transform.localScale *= multiplier;

		GetComponent<SpriteRenderer>().enabled = false;
		GetComponent<BoxCollider2D>().enabled = false;

		yield return new WaitForSeconds(dura);

		//Revert	
		//stats.health /= multiplier;

		Destroy(gameObject);
	}


	
}
