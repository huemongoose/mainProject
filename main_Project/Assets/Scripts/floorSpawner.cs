using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorSpawner : MonoBehaviour
{
    



    [SerializeField] GameObject spawner1;
    [SerializeField] GameObject spawner2;
    [SerializeField] GameObject spawner3;
    [SerializeField] GameObject spawner4;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Player")
        {
            Instantiate(spawner1);
            Instantiate(spawner2);
            Instantiate(spawner3);
            Instantiate(spawner4);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            GameObject[] go = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject g in go) {
                Destroy(g.gameObject);
            }
        }
    }

}
