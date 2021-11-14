﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectv2 : MonoBehaviour
{
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(1, 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zderzył się z kostką.");
        }
    }
}