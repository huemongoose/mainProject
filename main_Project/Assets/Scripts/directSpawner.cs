using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject DirectEnemy;
    [SerializeField] GameObject lockedDoor;

    [SerializeField] bool isLocked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Instantiate(DirectEnemy,transform.position,Quaternion.identity);
            if (isLocked)
            {
                lockedDoor.SetActive(true);
            }
        }
    }
}
