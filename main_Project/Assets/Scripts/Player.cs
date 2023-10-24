using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]  float playerSpeed = 10f;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    public bool hasBow = false;
    public bool hasBossKey = false;
    public int gems = 0;
    public int keys = 0;
    
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    

    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Health>().health > 100)
        {
            this.GetComponent<Health>().health = 100;
        }
        textMeshProUGUI.text = "Health " + this.GetComponent<Health>().health.ToString() +"\n" + "Gems " + gems ;
        if(keys > 0)
        {
            textMeshProUGUI.text = "Health " + this.GetComponent<Health>().health.ToString() + "\n" + "Gems " + gems + "\n" + "Keys " + keys;
        }
        if(hasBossKey)
        {
            textMeshProUGUI.text = "Health " + this.GetComponent<Health>().health.ToString() + "\n" + "Gems " + gems + "\n" + "Keys " + keys + "\n" + "Boss Key";


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
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement* playerSpeed * Time.deltaTime);
    }
    public void addGems(int value)
    {
        gems += value;
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
}
