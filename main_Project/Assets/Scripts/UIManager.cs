using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void OnEnable()
    {
        Player.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        Player.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
    public void RestartLevel()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
