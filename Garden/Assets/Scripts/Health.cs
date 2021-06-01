﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    public void DealDamage(float damage)
    {
        health -= damage;
  //      Debug.Log("HP:" + health);
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }
    private void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject deathVFXobject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXobject, 1f);
    }
}
