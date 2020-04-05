using System.Collections;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 10.0F;

    void Start()
    {
        
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
    }
}

