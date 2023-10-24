using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyePuzzle : MonoBehaviour
{
    [SerializeField] GameObject closedEye;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Arrow")
        {

            this.gameObject.SetActive(false);
            Instantiate(closedEye, transform.position, Quaternion.identity);
        }
    }
}
