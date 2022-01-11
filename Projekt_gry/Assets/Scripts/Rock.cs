using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    Rigidbody _rigidbody;
    bool rockDetDown;
    bool rockDetLeft;
    bool rockDetRight;
    public void UpdateDDown(bool exitD)
    {
        rockDetDown = exitD;
    }
    /*public void UpdateDLeft(bool exitL)
    {
        rockDetLeft = exitL;
    }
    public void UpdateDRight(bool exitR)
    {
        rockDetRight = exitR;
    }*/

    void Start()
    {
        _rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(rockDetDown)
        {
            _rigidbody.useGravity = false;
        }
        else
        {
            _rigidbody.useGravity = true;
        }
        //Debug.Log(rockDetDown);
    }
/*
    public Collider coll;

    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
    }*/
}
