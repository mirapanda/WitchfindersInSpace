using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject airlockText;
    public GameObject airlockText2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) && airlockText.activeInHierarchy)
        {
            Debug.Log("U key was pressed.");
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.U) && airlockText2.activeInHierarchy)
        {
            Debug.Log("U key was pressed.");
            SceneManager.LoadScene(3);
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
