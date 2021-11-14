using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AutomaticDoor : MonoBehaviour
{
     
    public GameObject movingDoor;
    public GameObject parentDoor;
     
    public float maximumOpening = 10f;
    public float maximumClosing = 0f;
     
    public float movementSpeed = 5f;
     
    bool playerIsHere;
     
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        if(playerIsHere)
        {
            if(movingDoor.transform.position.x < parentDoor.transform.position.x+(maximumOpening/2))
            {
                movingDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if(movingDoor.transform.position.x > parentDoor.transform.position.x)
            {
                movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }
         
         
    }
     
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }
     
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}