using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockedBossDorr : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if(player.hasBossKey)
            {
                Destroy(this.gameObject);
            }
        }
    }
}