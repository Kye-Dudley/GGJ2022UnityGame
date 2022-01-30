using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushFan : MonoBehaviour
{
    public GameObject player;
    private Vector3 initvel;
    private void Start()
    {
        initvel = transform.up * 5;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "HumanPlayer")
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.AddForce(initvel, ForceMode.Impulse);
            Debug.Log("HO");
        }
    }
}
