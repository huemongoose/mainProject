using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class Player : MonoBehaviour
{
    public static event Action OnPlayerDeath;


    public  float playerSpeed = 10f;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
  
    public bool hasBow = false;
    public bool hasFireStaff = false;

    public bool hasPotion = false;
    public bool hasBossKey = false;
    public int arrows = 25;
    public int gems = 0;
    public int keys = 0;

    public  bool isDead = false;

    Vector2  startPos;

    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject arrow;
    [SerializeField] GameObject downArrow;

    [SerializeField] GameObject playerFireBall;

    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    



    void Start()
    {

        gems = gameManager.getGems();
        hasBow = gameManager.getBow();
        hasFireStaff = gameManager.getStaff();
        Health health  = this.GetComponent<Health>();
        health.health = health.maxHealth;
        startPos = transform.position;
        EnablePlayerMovement();
        

        
    }

    // Update is called once per frame
    void Update()
    {
       
        textMeshProUGUI.text = "X " + gems ;
        if(keys > 0)
        {
          
            textMeshProUGUI.text += "\n" + "X" + keys;
        }
        if(hasBossKey)
        {
            textMeshProUGUI.text += "\n" + "Boss Key";

        }
        if (hasBow)
        {
            textMeshProUGUI.text += "\n" + "Arrows : " + arrows;
        }


        if (Input.GetKeyDown(KeyCode.Return) && hasBow && arrows > 0){
            arrows--;
            Shoot();
        }
        if(Input.GetKeyDown(KeyCode.Q) && hasFireStaff)
        {
            Instantiate(playerFireBall);
        }


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1|| Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastY", Input.GetAxisRaw("Vertical"));
        }

        



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            this.GetComponent<Health>().Damage(enemy.getDamage());
        }
        if(collision.gameObject.tag == "Boss")
        {
            
            int damage = collision.gameObject.GetComponent<boss>().getDamage();

            this.GetComponent<Health>().Damage(damage);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement* playerSpeed * Time.deltaTime);
    }
    public void addGems(int value)
    {
        gems += value;
        gameManager.addGems(value);
    }
    public void addKey()
    {
        keys += 1;
    }
    public void useKey()
    {
        keys--;
    }
    public void getBossKey()
    {
        hasBossKey = true;
    }
    public void useBossKey()
    {
        hasBossKey = false;
    }
    public void getArrows(int amt)
    {
        if (hasBow)
        {
            arrows += amt;
        }
        
    }
    public void getPotion()
    {
        hasPotion = true;
    }
    public void usePotion()
    {
        hasPotion = false;
    }
    void Shoot()
    {
       

        
        if (animator.GetFloat("lastY") < -.1)
        {
            Instantiate(downArrow, transform.position, Quaternion.identity);
        }
        if (animator.GetFloat("lastY") > .1)
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
        }
        if (animator.GetFloat("lastX") > .1)
        {
            Instantiate(rightArrow, transform.position, Quaternion.identity);
        }
        if (animator.GetFloat("lastX") < -.1)
        {
            Instantiate(leftArrow, transform.position, Quaternion.identity);
        }
        

    }
    public void die()
    {
        isDead = true;
        gameManager.gems = 0;
       
        OnPlayerDeath?.Invoke();
        
        
    }

    //respawn taken from https://www.youtube.com/watch?v=ZfRbuOCAeE8&pp=ygUSdW5pdHkgZGFtYWdlIGNvbG9y
    void DisablePlayerMovement()
    {
        animator.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }
    void EnablePlayerMovement()
    {
        animator.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;

    }

    private void OnEnable()
    {
        OnPlayerDeath += DisablePlayerMovement;
    }
    private void OnDisable()
    {
        OnPlayerDeath -= DisablePlayerMovement;
    }


}
