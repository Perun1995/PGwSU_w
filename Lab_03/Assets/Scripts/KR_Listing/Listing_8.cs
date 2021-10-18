using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listing_8 : MonoBehaviour
{
    public float distancePerFrame;
    
    void Update() {
        transform.Translate(0, 0, distancePerFrame);
    }

    /*
    public float distancePerSecond;
    
    void Update() {
        transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
    }
    
    
    
    */
}