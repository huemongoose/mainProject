using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.hasBossKey = true;
            Destroy(this.gameObject);
        }
    }
}

