using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountain : MonoBehaviour
{
    [SerializeField] healthBar healthBar;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.health = 100;
            healthBar.updateHealthBar(health.health, 100);
         
            
        }
    }
}
