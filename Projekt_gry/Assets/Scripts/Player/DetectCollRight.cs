using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollRight : MonoBehaviour
{
    public bool playerCRight;
    private Player gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Player>();
    }
    void Start()
    {
        playerCRight = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock")
        {
            playerCRight = true;
            gameManager.UpdateCRight(playerCRight);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock")
        {
            playerCRight = false;
            gameManager.UpdateCRight(playerCRight);
        }
    }
}
