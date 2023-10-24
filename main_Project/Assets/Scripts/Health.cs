using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public new GameObject camera;
    public Animator animator;
    [SerializeField] GameObject Gem;
    [SerializeField] GameObject Heart;
    [SerializeField] GameObject arrows;
  
    int spawnCount = 1;
    public SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
               
    }
    void Update()
    {
        



        if (health <= 0)
        {
            if(this.gameObject.tag == "Player")
            {
               if(this.GetComponent<Player>().hasPotion)
                {
                    health = 100;
                    this.GetComponent<Player>().usePotion();
                }
                camera.SetActive(true);
                Destroy(this.gameObject);
            }
            else if (spawnCount == 0)
            {
                Destroy(this.gameObject);
            }
            else if(this.gameObject.tag == "Enemy")
            {
                if(Random.Range(0,5) == 0)
                {
                    Instantiate(Gem, transform.position, Quaternion.identity);
                }
                else if(Random.Range(0,5) == 1)
                {
                    Instantiate(Heart, transform.position, Quaternion.identity);
                }
                else if(Random.Range(0,5) == 2)
                {
                    Instantiate(arrows, transform.position, Quaternion.identity);
                }
               
                spawnCount = 0; 

            }
            else
            {
                Destroy(this.gameObject) ;
            }
        }
        
    }

    // Update is called once per frame
    public void Damage(int damage)
    {

        StartCoroutine(flashred());
        health -= damage;
    }
    public void Heal(int heal)
    {

        health += heal;
        
    }
    public IEnumerator flashred()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        sprite.color = Color.white;
    }
}
