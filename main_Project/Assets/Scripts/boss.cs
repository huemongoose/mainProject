using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    [SerializeField] int damage;
    private Transform player;

    public float shootingRange;
    public GameObject fireBall;
    public GameObject fireBallParent;
    public float speed;
    public float fireRate = 1f;
    public float eyeSpawnRate = 2f;
    public float nextFireTime;

    [SerializeField] float distance;
    [SerializeField] float range;

    public GameObject eyeEnemy;

    



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if (distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {
            Instantiate(fireBall, fireBallParent.transform.position, Quaternion.identity);
            Instantiate(fireBall, fireBallParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
        else if (distanceFromPlayer <= shootingRange && eyeSpawnRate < Time.time)
        {
            Instantiate(eyeEnemy, fireBallParent.transform.position, Quaternion.identity);
            Instantiate(eyeEnemy, fireBallParent.transform.position, Quaternion.identity);
            eyeSpawnRate = Time.time + fireRate;
        }
        else if (distanceFromPlayer < range)
        {
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
        
            Gizmos.DrawWireSphere(transform.position, shootingRange);
        
    }
}
