using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public Animator animator;
    GameObject grabbedObj;
    public Rigidbody rb;
    public int isLeftorRight;
    public bool alreadtGrabbing = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public bool usemouse = true;
    public KeyCode GrabLeft = KeyCode.None;
    public KeyCode GrabRight = KeyCode.None;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(isLeftorRight))
        {
            if(isLeftorRight == 0)
            {
                animator.SetBool("isLeftHandUp", true);
            }
            else if (isLeftorRight == 1)
            {
                animator.SetBool("isRightHandUp", true);
            }

            FixedJoint fj = grabbedObj.AddComponent<FixedJoint>();
            fj.connectedBody = rb;
            fj.breakForce = 9000;

        }
        else if (Input.GetMouseButtonUp(isLeftorRight))
        {
            if (isLeftorRight == 0)
            {
                animator.SetBool("isLeftHandUp", false);
            }
            else if (isLeftorRight == 1)
            {
                animator.SetBool("isRightHandUp", false);
            }
            if  (grabbedObj != null)
            {
                Destroy(grabbedObj.GetComponent<FixedJoint>());
            }
            grabbedObj = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            grabbedObj = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        grabbedObj = null;
    }

}
