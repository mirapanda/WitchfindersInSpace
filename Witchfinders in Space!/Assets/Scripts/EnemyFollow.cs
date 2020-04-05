using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform playerHere;
    public Transform enemyHere;

    public float enemySpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerHere);
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }
}
