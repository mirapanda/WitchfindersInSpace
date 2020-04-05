using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingAirlock2 : MonoBehaviour
{

    public GameObject airlockText2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            airlockText2.SetActive(true);
        }
    }

}