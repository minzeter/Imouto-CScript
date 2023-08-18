using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject PotionPrefab;
    public float reSpawnTime = 20f;

    public UpSideDown _UpSideDown;

    public void spawnPotion()
    {
        GameObject a = Instantiate(PotionPrefab) ;
        a.transform.position = new Vector2();
    }

    private void FixedUpdate()
    {
        if (_UpSideDown._potionCheck == true)
        {
            StartCoroutine("Alibaba");
            spawnPotion();
        }

    }

    IEnumerator Alibaba()
    {
        
        yield return new WaitForSeconds(15f)
            ;
    }
}
