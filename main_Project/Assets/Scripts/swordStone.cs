using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordStone : MonoBehaviour
{
    public Animator animator;
    public GameObject sceneLoader;

    public GameObject textbox;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        health.health = 150;
        animator.SetBool("isTaken", true);
        sceneLoader.SetActive(true);
        textbox.SetActive(true);

        
    }
}
