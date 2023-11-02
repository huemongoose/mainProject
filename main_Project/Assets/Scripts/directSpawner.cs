using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject DirectEnemy;
    [SerializeField] GameObject lockedDoor;
    [SerializeField] GameObject reward;
    [SerializeField] int amount;
    public int enemies;
    public int bosses;
    public bool isComplete = false;

    [SerializeField] bool isLocked;
    [SerializeField] bool playerIn = false;
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        bosses = GameObject.FindGameObjectsWithTag("Boss").Length;
      
        if(!isComplete && playerIn && enemies == 0 && bosses == 0)
        {


            lockedDoor.SetActive(false);
            reward.SetActive(true);
            isComplete = true;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if(collision.tag == "Player")
        {
            
            playerIn = true;
            if (isComplete == false)
            {
                DirectEnemy.SetActive(true);
             
                if (isLocked)
                {
                    lockedDoor.SetActive(true);
                }
            }
            
        }
        
    }
    
}
