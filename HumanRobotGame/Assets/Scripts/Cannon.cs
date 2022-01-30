using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Player;
    public GameObject cannonBallPrefab;
    public Transform fireloc;
    private Vector3 initvel;
    private float nextActionTime = 0.0f;
    public float period = 1.1f;

    private void FixedUpdate()
    {
        this.transform.LookAt(Player.transform);
    }
    private void FireCannon()
    {
        initvel = transform.forward * 10;
        GameObject cannonBall = Instantiate(cannonBallPrefab, fireloc.position, Quaternion.identity);
        Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.AddForce(initvel, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collision other)
    {
        if(other.gameObject.tag == "HumanPlayer")
        {
            InvokeRepeating("FireCannon", 1f, 1f);
        }
    }
    private void OnTriggerExit(Collision other)
    {
        if (other.gameObject.tag == "HumanPlayer")
        {
            InvokeRepeating("FireCannon", 1f, 1f);
        }
    }
}
