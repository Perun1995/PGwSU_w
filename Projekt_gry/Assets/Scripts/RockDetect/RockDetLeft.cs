/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDetLeft : MonoBehaviour
{
    public bool playerDLeft;
    private Rock gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Rock>();
    }
    void Start()
    {
        playerDLeft = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt")
        {
            playerDLeft = true;
            gameManager.UpdateDLeft(playerDLeft);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt")
        {
            playerDLeft = false;
            gameManager.UpdateDLeft(playerDLeft);
        }
    }
}
*/