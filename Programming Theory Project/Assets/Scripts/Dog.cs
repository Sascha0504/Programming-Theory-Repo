using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 8;
        jumpForceBase = 1;
        
        Initialize();
       
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();

        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }

    public override void MakeNoise()
    {
        //play dog sound
    }
}
