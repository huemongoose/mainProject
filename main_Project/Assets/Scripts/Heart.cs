using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int value;

    void Start()
    {
        value = Random.Range(5, 15);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.Heal(value);
            Destroy(this.gameObject);

        }
    }
}
