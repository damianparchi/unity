using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3Move2 : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;

    void Update()
    {
        if(Vector3.Distance(dir,transform.position) >= 10)
        {
            dir = transform.position;
            transform.Rotate(0, 90, 0, Space.World);
        }
        else
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
