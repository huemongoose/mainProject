using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{
    [SerializeField] int damage = 20;
    [SerializeField] int speed = 15;

    // Start is called before the first frame update


    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" || collision.tag == "Enemy" || collision.tag == "Boss")
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
