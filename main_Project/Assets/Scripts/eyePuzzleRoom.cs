using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyePuzzleRoom : MonoBehaviour
{
    [SerializeField] GameObject openEye;
    [SerializeField] GameObject Reward;
    public bool isComplete = false;

    // Update is called once per frame
    void Update()
    {

        if (!openEye.activeInHierarchy && isComplete == false)
        {
            Reward.SetActive(true) ;
            isComplete = true ;
        }
        
    }
}
