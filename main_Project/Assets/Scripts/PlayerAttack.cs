using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public bool attack = false;
    public GameObject attackArea;
    public GameObject backAttackArea;
    public GameObject LeftAttackArea;
    public GameObject RightAttackArea;
    public Animator animator;

    void Start()
    {
        attackArea = transform.GetChild(1).gameObject;
        backAttackArea = transform.GetChild(2).gameObject;
        LeftAttackArea = transform.GetChild(3).gameObject;
        RightAttackArea  = transform.GetChild(4).gameObject;

        
    }

    void Update()

    {
        animator.SetBool("isAttack", false);
        attackArea.SetActive(false);
        backAttackArea.SetActive(false);
        LeftAttackArea.SetActive(false);
        RightAttackArea.SetActive(false);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(animator.GetFloat("lastY") < -.1)
            {
                attackArea.SetActive(true);
            }
            if(animator.GetFloat("lastY") > .1)
            {
                backAttackArea.SetActive(true) ;
            }
            if(animator.GetFloat("lastX") > .1){
                RightAttackArea.SetActive(true ) ;
            }
            if(animator.GetFloat("lastX") < -.1)
            {
                LeftAttackArea.SetActive(true );
            }
            else
            {
                attackArea.SetActive(true);
            }
            attack = true;
            animator.SetBool("isAttack", true);
            
        }


        attack = false;
        
        
    }

}
