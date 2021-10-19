using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LewoPrawo1_2 : MonoBehaviour
{

    public float speed = 10.0f;
    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        if(rb.position.x >= 10)         
        {
            rb.AddForce(Vector3.left, ForceMode.Impulse);
        }
        if(rb.position.x <= 0)
        {
            rb.AddForce(Vector3.right, ForceMode.Impulse);
        }     

    }    
}