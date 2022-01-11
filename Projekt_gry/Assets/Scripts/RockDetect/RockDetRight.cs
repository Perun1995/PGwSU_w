/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDetRight : MonoBehaviour
{
    public bool rockDRight;
    private Rock gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<Rock>();
    }
    void Start()
    {
        rockDRight = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt")
        {
            rockDRight = true;
            gameManager.UpdateDRight(rockDRight);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "SteelBlock" || col.gameObject.tag == "Rock" || col.gameObject.tag == "Diamont" || col.gameObject.tag == "Dirt")
        {
            rockDRight = false;
            gameManager.UpdateDRight(rockDRight);
        }
    }
}
*/