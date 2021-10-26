using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Player : MonoBehaviour
{
    public Master control;

    private void Awake()
    {
        control.Player.Shoot.performed +=_=> Shoot();
    }

    void Shoot()
    {

    }

    
}
