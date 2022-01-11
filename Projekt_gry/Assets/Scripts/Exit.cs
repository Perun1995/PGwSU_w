using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool playerIsHere;
    private GameManager gameManager;
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = true;
            gameManager.UpdateExit(playerIsHere);
        }
    }
     
    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = false;
            gameManager.UpdateExit(playerIsHere);
        }
    }
}
