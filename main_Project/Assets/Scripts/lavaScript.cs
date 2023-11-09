using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaScript : MonoBehaviour
{

    public int damage = 10;
    public float damageTimer = 1f;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        health.Damage(damage);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(damageTimer == 1f)
        {
            Health health = collision.GetComponent<Health>();
            health.Damage(damage);
        }
        else if(damageTimer == 0f)
        {
            damageTimer = 1f;
        }
        damageTimer -= Time.deltaTime;
        

    }
}
