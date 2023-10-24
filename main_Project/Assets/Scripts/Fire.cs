using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour

{
    public int damage = 5;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sword")
        Destroy(this.gameObject); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.Damage(damage);
        }
    }
}
