using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCatch : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            gameManager.GameOver();
        }

    }

}
