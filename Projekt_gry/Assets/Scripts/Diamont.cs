using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamont : MonoBehaviour
{
    public int hits = 1;
    public int points = 1;
    public Vector2 rotator;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if (hits <= 0 && collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Score += points;
            Destroy(gameObject);
        }
    }
}
