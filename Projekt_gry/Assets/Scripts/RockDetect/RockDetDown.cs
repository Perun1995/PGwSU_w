using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDetDown : MonoBehaviour
{
    public bool rockDDown;
    private Rock gameManager;
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Rock>();
    }
    void Start()
    {
        rockDDown = false;
    }

    private void Update()
    {
        //gameManager = GameObject.FindObjectOfType<Rock>();
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt" || col.gameObject.tag == "Player")
        {
            rockDDown = true;
            gameManager.UpdateDDown(rockDDown);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt" || col.gameObject.tag == "Player")
        {
            rockDDown = false;
            gameManager.UpdateDDown(rockDDown);
        }
    }
}
