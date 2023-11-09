using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kingScript : MonoBehaviour
{
    [SerializeField] GameObject textbox;

    [SerializeField] GameObject sword;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textbox.SetActive(true);
        sword.SetActive(true);
    }
}
