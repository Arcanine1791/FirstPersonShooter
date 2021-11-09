using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PController : MonoBehaviour
{
    public PlayerInputActions pia;

    private void Start()
    {
        pia = new PlayerInputActions();
        pia.Abinav.Enable();
        pia.Abinav.jump.performed += ctc=>jumpforme();
    }

    private void Update()
    {
        Debug.Log(pia.Abinav.kadulu.ReadValue<Vector2>());
        Vector2 xandy = pia.Abinav.kadulu.ReadValue<Vector2>();
        transform.position += new Vector3(xandy.x, 0, xandy.y);

    }

    public void jumpforme()
    {
        Debug.Log(" Jumpped");
    }
}
