using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3Zad4 : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(move*speed);
        
    }
}
