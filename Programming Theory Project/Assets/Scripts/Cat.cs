using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    Cat Instance;

    // Start is called before the first frame update
    void Start()
    {
        this.playerSpeed = 5;
        this.jumpForceBase = 2;
        this.jumpForce = jumpForceBase;
        Initialize();
        if (Instance != null)
        {
            Destroy(gameObject);
            return;

        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

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
}
