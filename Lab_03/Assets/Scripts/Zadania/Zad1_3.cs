using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1_3 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        m_EulerAngleVelocity = new Vector3(0, 90, 0);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(rb.velocity.x == 0 &&  rb.position.x == 0)
        {
            rb.AddForce(speed,0,0, ForceMode.VelocityChange);
            
        }
        if(rb.velocity.x == speed && rb.position.x >= 10)
        {
            rb.AddForce((-speed),0,(-speed), ForceMode.VelocityChange);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        if(rb.velocity.z == -speed && rb.position.z <= -10)
        {
            rb.AddForce(-speed,0,speed, ForceMode.VelocityChange);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        if(rb.velocity.x == -speed && rb.position.x <= 0)
        {
            rb.AddForce(speed,0,speed, ForceMode.VelocityChange);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
         if(rb.velocity.z == speed && rb.position.z >= 0)
        {
            rb.AddForce(speed,0,-speed, ForceMode.VelocityChange);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }    
   
}

