﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listing04 : MonoBehaviour //LookAround
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        // aby w UnityEditor ponownie pojawił się kursor (właściwie deaktywowac kursor w trybie play)
        // wciskamy klawisz ESC
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * Time.deltaTime;

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerę
        transform.Rotate(new Vector3(mouseYMove, 0f, 0f), Space.Self);
    }
}