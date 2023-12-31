using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(this.gameObject);
            Player player = collision.GetComponent<Player>();
            player.addKey();
        }
    }
}
