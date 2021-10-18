using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listing_3 : MonoBehaviour
{

    // nawet jeżeli to pole publiczne może je ukryć poprzez użycie
    [HideInInspector]
    public float force = 10.0f;
    // lub prywatne pole w inspektorze wyświetlić poprzez
    [SerializeField]
    private float power = 5.0f;
    public Rigidbody rb;
    
    void Start()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}