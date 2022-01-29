using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform root;

    float mouseX, mouseY;

    public float stomachOffset;
    public ConfigurableJoint hipJoint, stomachJoint;
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        Quaternion rootRotation = Quaternion.Euler(0, mouseX, mouseY);
        root.rotation = rootRotation;
    }

    void FixedUpdate()
    {
        //turning
        hipJoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        //leaning
        stomachJoint.targetRotation = Quaternion.Euler(0 + stomachOffset, 0, -mouseY);
    }
}
