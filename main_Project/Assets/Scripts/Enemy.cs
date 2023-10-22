using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed ;
    [SerializeField] Vector2 target;
    [SerializeField] Vector2 pos;
    [SerializeField] float time;
    [SerializeField] int damage;
    

    Vector2 point;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        SetnewDestination();
    }

    // Update is called once per frame
    void Update()
    {
       
       transform.position = Vector2.MoveTowards(transform.position, target, speed *Time.deltaTime);
        time-= Time.deltaTime;

        if(time <= 0)
        {
            SetnewDestination();
        }
         
        








    }
    void SetnewDestination()
    {
        target = new Vector2(Random.Range(-10f,10f), Random.Range(-10f,10f));
    }
    public int getDamage()
    {
        return damage;
    }
}
