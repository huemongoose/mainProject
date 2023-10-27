using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{
    [SerializeField] int damage = 20;
    [SerializeField] int speed = 15;

    Rigidbody2D fireBallRb;
    GameObject target;

    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        fireBallRb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        fireBallRb.velocity = new Vector2(moveDir.x, moveDir.y);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" )
        {
            Health health  = collision.GetComponent<Health>();
            health.Damage(damage);
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
