using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public new GameObject camera;
    public Animator animator;
    [SerializeField] GameObject Gem;
    
    // Start is called before the first frame update
    void Start()
    {
               
    }
    void Update()
    {
       
        if(health <= 0)
        {
            
            Destroy(this.gameObject);
            
            
            if(this.gameObject.tag == "Player")
            {
                camera.SetActive(true);
            }
        }
        
    }

    // Update is called once per frame
    public void Damage(int damage)
    {
        if (this.gameObject.tag == "enemy")
        {
            animator.SetBool("isDamaged", true);
        }
        health -= damage;
    }
    public void Heal(int heal)
    {

        health += heal;
        
    }
}
