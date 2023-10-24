using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField] GameObject fireball;
    private void Update()
    {
        int rand = Random.Range(0, 20);
        if(rand < 5)
        {

            Instantiate(fireball);
        }
    }

    
}
