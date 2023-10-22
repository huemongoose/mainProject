using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject chest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.anyKey)
        {
            Destroy(this.gameObject);
            Instantiate(chest,transform.position,Quaternion.identity);
            Instantiate(item,transform.position,Quaternion.identity);
        }
        
    }
}
