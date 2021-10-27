using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Player : MonoBehaviour
{
    public MainInput inputControl;
    public InputAction movment;

    private void Awake()
    {
        inputControl = new MainInput();
    }

    private void OnEnable()
    {
        movment = inputControl.Player.Move;
        movment.Enable();

        inputControl.Player.Jump.performed += Jump;
        inputControl.Player.Jump.Enable();
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        GameEvents.instance.OnEnemyDead();
    }

    private void OnDisable()
    {
        movment.Disable();
        inputControl.Player.Jump.Disable();
    }

    private void FixedUpdate()
    {
        Debug.Log("movement values" + movment.ReadValue<Vector2>());
        Vector2 move = movment.ReadValue<Vector2>();

        transform.position += new Vector3(move.x, 0, move.y);
    }


    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
           
        //}
    }
}
