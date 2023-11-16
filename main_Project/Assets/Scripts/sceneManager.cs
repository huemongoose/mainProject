using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public static sceneManager Instance;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(SceneManager.GetActiveScene().name == "dungeonOne")
        {
            SceneManager.LoadScene(sceneName: "dungeon2");
        }
        else if (SceneManager.GetActiveScene().name == "dungeon2")
        {
            SceneManager.LoadScene(sceneName: "dungeonOne");
        }
       
    }
}
