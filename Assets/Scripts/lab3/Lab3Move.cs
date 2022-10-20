using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3Move : MonoBehaviour
{
    public float speed = 5;
    bool goback = false;

    void Update()
    {
        if(transform.position.x <= 0)
        {
            goback = false;
        }

        if(transform.position.x >= 10)
        {
            goback = true;
        }
        
        if (goback)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        } else {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}

