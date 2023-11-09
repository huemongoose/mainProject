using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{


    private GameObject attackArea;
    private GameObject backAttackArea;
    private GameObject LeftAttackArea;
    private GameObject RightAttackArea;
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
            if (animator.GetFloat("lastY") < -.1)
            {
                Attack(0);
            }
            else if (animator.GetFloat("lastY") > .1)
            {
                Attack(1);
            }
            else if (animator.GetFloat("lastX") > .1)
            {
                Attack(2);
            }
            if (animator.GetFloat("lastX") < -.1)
            {
                Attack(3);
            }
            else
            {
                Attack(0);
            }

            animator.SetBool("isAttack", true);



        }





    }
    private void Attack(int n)
    {
        switch (n)
        {
            case 0:
                attackArea.SetActive(true);
                break;
            case 1:
                backAttackArea.SetActive(true);
                break;
            case 2:
                LeftAttackArea.SetActive(true);
                break;
            case 3:
                RightAttackArea.SetActive(true);
                break;
        }
    }


}
