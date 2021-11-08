using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listing2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zderzył się z kostką.");
        }
    }
}

/*
...
private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "zolta_kostka")
        {
            Debug.Log("Wykryto kolizję kostki z Character Controller");
        }
        ...
    }
...
*/




/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
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
*/