using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftArrow : MonoBehaviour
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
        transform.position = new Vector2(transform.position.x- speed * Time.deltaTime, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null && collider.tag != "Player")
        {
            Health health = collider.GetComponent<Health>();
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
