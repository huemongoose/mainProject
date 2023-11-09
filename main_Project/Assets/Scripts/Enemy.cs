using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] int damage;
    private Transform player;

    public float shootingRange;
    public GameObject fireBall;
    public GameObject fireBallParent;
    public float speed;
    public bool isShooter = false;
    public float fireRate = 2f;
    public float nextFireTime;

    public bool playerStatus;

    [SerializeField] float distance;
    [SerializeField] float range;

     



    // Start is called before the first frame update
    void Start()
    {
        playerStatus = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isDead ;
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        
        if(!playerStatus && isShooter && distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {
            Instantiate(fireBall, fireBallParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
        else if(!playerStatus && distanceFromPlayer < range) {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        
       


    }
    
    public int getDamage()
    {
        return damage;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, range);
        if(isShooter )
        {
            Gizmos.DrawWireSphere(transform.position, shootingRange);
        }
    }
}
