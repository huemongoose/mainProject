using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireStaff : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;

    public GameObject fireball;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && player.hasFireStaff)
        {
            Instantiate(fireball);
        }
    }



}
