using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    public Transform pointA;
    private float pointAx;
    private float pointBx;
    public Transform pointB;
    public float speed = 2f;
    private bool st;

    public bool moveRight;

    void Start()
    {
        pointAx = pointA.position.x;
        pointBx = pointB.position.x;
    }

    private void FixedUpdate()
    {
        if(st==true)
        {
            if(moveRight == true)
            {
                transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0);
            }
            if (transform.position.x <= pointB.position.x)
            {
                moveRight = true;
            }
            if(transform.position.x >= pointAx)
            {
                moveRight = false;
            }
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł na platformę");
            st = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszedł z platformy.");
        }
    }
}
