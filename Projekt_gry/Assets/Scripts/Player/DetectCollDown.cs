using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollDown : MonoBehaviour
{
    public bool playerCDown;
    private Player gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Player>();
    }
    void Start()
    {
        playerCDown = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock")
        {
            playerCDown = true;
            gameManager.UpdateCDown(playerCDown);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock")
        {
            playerCDown = false;
            gameManager.UpdateCDown(playerCDown);
        }
    }
}
