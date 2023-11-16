using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpStaff : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.hasFireStaff = true;
            gameManager.addStaff();
            Destroy(this.gameObject);
        }
    }
}
