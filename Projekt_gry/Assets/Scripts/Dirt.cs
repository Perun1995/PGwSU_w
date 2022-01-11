using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    public int hits = 1;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if (hits <= 0 && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
