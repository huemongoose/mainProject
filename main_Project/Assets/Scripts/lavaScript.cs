using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaScript : MonoBehaviour
{

    public int damage = 10;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        Health health = GetComponent<Health>();
        health.Damage(damage);

    }
}
