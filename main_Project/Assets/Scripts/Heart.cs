using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int value;

    void Start()
    {
        value = Random.Range(15, 30);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if(health.health  + value > 100)
            {
                health.health = 100;
            }
            else
            {
                health.Heal(value);
            }
           
            Destroy(this.gameObject);

        }
    }
}
