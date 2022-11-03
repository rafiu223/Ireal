﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermor : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;



    // Update is called once per frame
    void Update()
    {

       horizontalMove = Input.GetAxisRaw("Horizontal") * runSeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }
     void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
    }
}