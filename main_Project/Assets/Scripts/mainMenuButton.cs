using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMenuButton : MonoBehaviour
{
    public static sceneManager Instance;
    // Start is called before the first frame update
    public void loadGame()
    {
        SceneManager.LoadScene(sceneName: "OpeningScene");

    }
}
