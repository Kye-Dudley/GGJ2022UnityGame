using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float speed;
    public float strafeSpeed;
    public float JumpForce;

    //Animation
    public Animator animator;

    //Physics
    public Rigidbody hips;
    public bool isGrounded;
    public bool canJump = false;

    //Inputs
    KeyCode MoveForwards = KeyCode.W;
    KeyCode MoveBackwards = KeyCode.W;
    KeyCode MoveLeft = KeyCode.W;
    KeyCode MoveRight = KeyCode.W;
    KeyCode Jump = KeyCode.W;

    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        //get keys for movements. Replace these later for two player!
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);
            hips.AddForce(-hips.transform.forward * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalk", true);
            hips.AddForce(hips.transform.forward * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalk", true);
            hips.AddForce(hips.transform.right * strafeSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalk", true);
            hips.AddForce(-hips.transform.right * strafeSpeed);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        //two different methods of input. both work.
        if (canJump == true)
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (isGrounded)
                {
                    hips.AddForce(new Vector3(0, JumpForce, 0));
                    isGrounded = false;
                }
            }
        }
    }
}
