using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public static sceneManager Instance;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneName: "dungeon2");
    }
}
