using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Arrow")
        {
            Destroy(this.gameObject);
        }
    }
}
