using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour
{
    [SerializeField] int damage = 5;
    [SerializeField] float speed = 12f;
 
    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Health health = collision.GetComponent<Health>();
            health.Damage(damage);
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {

            Destroy(this.gameObject);

        }

    }
}
