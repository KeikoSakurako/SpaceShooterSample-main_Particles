using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootbag : MonoBehaviour
{
    public GameObject dropItemPre;
    public List<Loot> lootlist = new List<Loot>();
    //public GameObject[] loolist;


    Loot GetDropItem()
    {
        int randomNumer = Random.Range(1, 100);
        List<Loot> possibleItem = new List<Loot>();
        foreach (Loot item in lootlist)
        {
            if (randomNumer <= item.dropChance)
            {
                possibleItem.Add(item);
            }
        }


        if (possibleItem.Count > 0)
        {
            Loot droppitem = possibleItem[Random.Range(0, possibleItem.Count)];
            return droppitem;

        }

        return null;
    }


    public void InstatiateLoot(Vector3 spawntion)
    {
        Loot dropitem = GetDropItem();
        if (dropitem != null)
        {
            GameObject lootgameObject = Instantiate(dropItemPre, spawntion, Quaternion.identity);
            lootgameObject.GetComponent<SpriteRenderer>().sprite = dropitem.lootsprite;
            //lootgameObject.GetComponent<GameObject>(). = dropitem.lootsprite;
            //lootgameObject.GetComponent<SpdBuff>();

            float dropForce = 30f;
            Vector2 dropDir = new Vector2(Random.Range(-1f, 1), Random.Range(-1f, 1));
            lootgameObject.GetComponent<Rigidbody2D>().AddForce(dropDir * dropForce, ForceMode2D.Impulse);

        }
    }

}
