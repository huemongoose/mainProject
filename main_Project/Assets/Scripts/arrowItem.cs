using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowItem : MonoBehaviour
{
    public int amt;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        amt = Random.Range(1, 20);
        if(collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.getArrows(amt);
            Destroy(this.gameObject);

        }
    }


}
