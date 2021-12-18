using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animal : MonoBehaviour
{
    protected float playerSpeed;
    protected float rotationSpeed = 50;
    protected float jumpForceBase;
    protected CharacterController controller;
    [SerializeField]protected float jumpForce;
    [SerializeField]protected bool isGrounded = true;
    private Vector3 playerVelocity;
    private float gravityValue = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    




    public virtual void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Sprint"))
        {
            playerSpeed *= 3 ;
        }
        if (Input.GetButtonUp("Sprint"))
        {
            playerSpeed /= 3;
        }
        controller.Move(verticalInput * transform.forward * Time.deltaTime * playerSpeed);
        transform.Rotate(horizontalInput * Vector3.up * Time.deltaTime * rotationSpeed);
      
        isGrounded = controller.isGrounded;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public virtual void Jump() 
    {
        playerVelocity.y += Mathf.Sqrt(jumpForce * -3.0f * gravityValue) ;
        jumpForce = jumpForceBase;
    }

    public void Initialize()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }


  
 }
