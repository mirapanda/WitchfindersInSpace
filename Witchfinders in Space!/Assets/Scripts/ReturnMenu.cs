using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public GameManager gameManager;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        gameManager.QuitGame();
        Debug.Log("Quit");
    }
}
