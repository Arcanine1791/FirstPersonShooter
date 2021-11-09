using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public NewPlayerActions ip;

    private void Start()
    {
        ip = new NewPlayerActions();
        ip.Player.Enable();
  
    }


    private void Update()
    {
        Vector2 move = ip.Player.Move.ReadValue<Vector2>();
        transform.position += new Vector3(move.x, move.y,0);
    }
}
