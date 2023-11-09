using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transporttoDungeon1 : MonoBehaviour
{
    [SerializeField] Animator animator;
    public static SceneManager instance;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("isTaken", true);

        SceneManager.LoadScene(sceneName: "dungeonOne");

    }


}
