using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Player : MonoBehaviour
{
    public MainInput inputControl;

    private void Awake()
    {
        inputControl = new MainInput();
    }
    private void OnEnable()
    {
        inputControl.Player.Enable();

        inputControl.Player.Jump.performed += Jump;
        inputControl.Player.Jump.Enable();
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        GameEvents.instance.OnEnemyDead();
    }

    private void OnDisable()
    {
        inputControl.Player.Disable();
    }

    private void FixedUpdate()
    {
        Debug.Log("movement values" + inputControl.Player.Move.ReadValue<Vector2>());
        Vector2 move = inputControl.Player.Move.ReadValue<Vector2>();

        transform.position += new Vector3(move.x, 0, move.y);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hello");
        }
    }
}
