using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trader : MonoBehaviour
{
    [SerializeField] GameObject messageBox;

    [SerializeField] int price;
    [SerializeField] int speedPrice;
    [SerializeField] int arrowQuantity;
    [SerializeField] int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        messageBox.SetActive(true);
        Player player = GetComponent<Player>(); 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        messageBox.SetActive(false);
        Player player = collision.GetComponent<Player>();
    }

    public void sellItem1()
    {

        Player player = GetComponent<Player>();
        if (player.gems >= price)
        {
            player.gems -= price;
            player.hasPotion = true;
        }
    
    }
    public void sellItem2()
    {
        Player player = GetComponent<Player>();
        if(player.gems >= price) {
            player.gems -= price;
            player.getArrows(arrowQuantity);

        }

    }
    public void sellItem3()
    {
        Player player = GetComponent<Player>();
        if(player.gems >= speedPrice)
        {
            player.gems -= speedPrice;
            player.playerSpeed += 5;

        }

    }
    public void close()
    {
        messageBox.SetActive(false);
    }
}
