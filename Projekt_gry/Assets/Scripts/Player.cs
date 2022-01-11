using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rigidbody;
    Renderer _renderer;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.2f;

    public float moveDirection = 0;
    //public float moveSpeed = 2f;
    bool playerCollRight;
    bool playerCollLeft;
    bool playerCollDown;
    bool playerCollUp;
    public void UpdateCRight(bool exitR)
    {
        playerCollRight = exitR;
    }
    public void UpdateCLeft(bool exitL)
    {
        playerCollLeft = exitL;
    }
    public void UpdateCUp(bool exitU)
    {
        playerCollUp = exitU;
    }
    public void UpdateCDown(bool exitD)
    {
        playerCollDown = exitD;
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    private void DetectMovement()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        //transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        if(Input.GetKey(KeyCode.W) && !isMoving && !playerCollUp) StartCoroutine(MovePlayer(Vector3.up));
        if(Input.GetKey(KeyCode.S) && !isMoving && !playerCollDown) StartCoroutine(MovePlayer(Vector3.down));
        if(Input.GetKey(KeyCode.A) && !isMoving && !playerCollLeft) StartCoroutine(MovePlayer(Vector3.left));
        if(Input.GetKey(KeyCode.D) && !isMoving && !playerCollRight) StartCoroutine(MovePlayer(Vector3.right));
        
    }
    void FixedUpdate()
    {
        if(!_renderer.isVisible)
        {
            GameManager.Instance.Life--;
            Destroy(gameObject);
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedTime = 0;
        origPos = transform.position;
        targetPos = origPos + direction*2;
        while(elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }
   
}
