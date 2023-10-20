using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Bats;
    [SerializeField] GameObject Apparitions;
    [SerializeField] GameObject Spiders;
    [SerializeField] GameObject Slimes;
    [SerializeField] GameObject Wizards;

    [SerializeField] int enemyAmt;



    void Start()
    {
        while (enemyAmt > 0)
        {
            int rand = Random.Range(0, 6);
            if (rand <= 1)
            {
                Instantiate(Bats, transform.position, Quaternion.identity);
            }
            else if (rand > 1 && rand <= 2)
            {
                Instantiate(Apparitions, transform.position, Quaternion.identity);
            }
            else if (rand > 2 && rand <= 3)
            {
                Instantiate(Spiders, transform.position, Quaternion.identity);
            }
            else if (rand > 3 && rand <= 4)
            {
                Instantiate(Slimes, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(Wizards, transform.position, Quaternion.identity);
            }

            enemyAmt--;
        }


    }

        // Update is called once per frame
        
          
                    
    }
