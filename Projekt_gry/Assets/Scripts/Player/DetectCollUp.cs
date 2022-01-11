using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollUp : MonoBehaviour
{
    public bool playerCUp;
    private Player gameManager;
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Player>();
    }
    void Start()
    {
        playerCUp = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock")
        {
            playerCUp = true;
            gameManager.UpdateCUp(playerCUp);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock")
        {
            playerCUp = false;
            gameManager.UpdateCUp(playerCUp);
        }
    }
}
