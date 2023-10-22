using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public int gemValue;
    // Start is called before the first frame update
    void Start()
    {
        gemValue = Random.Range(5, 25);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.addGems(gemValue);
            Destroy(this.gameObject);
        }
    }
}
