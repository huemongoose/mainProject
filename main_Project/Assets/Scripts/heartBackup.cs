using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartBackup : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.getPotion();
            Destroy(this.gameObject);
        }
    }
}
