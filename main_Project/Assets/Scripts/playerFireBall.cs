using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class playerFireBall : MonoBehaviour
{
    [SerializeField] int damage = 20;
    [SerializeField] int speed = 15;

    Rigidbody2D fireBallRb;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        fireBallRb = GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Enemy");
        if(target != null)
        {
            Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
            fireBallRb.velocity = new Vector2(moveDir.x, moveDir.y);
        }
      


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Enemy")
        {
            Health health = collision.GetComponent<Health>();
            health.Damage(damage);
            Destroy(this.gameObject);
        }
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}

  
