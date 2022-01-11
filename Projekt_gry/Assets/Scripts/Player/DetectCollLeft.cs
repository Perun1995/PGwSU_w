using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollLeft : MonoBehaviour
{
    public bool playerCLeft;
    private Player gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Player>();
    }
    void Start()
    {
        playerCLeft = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock")
        {
            playerCLeft = true;
            gameManager.UpdateCLeft(playerCLeft);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock")
        {
            playerCLeft = false;
            gameManager.UpdateCLeft(playerCLeft);
        }
    }
}
