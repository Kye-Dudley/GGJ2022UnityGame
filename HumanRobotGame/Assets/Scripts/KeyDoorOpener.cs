using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorOpener : MonoBehaviour
{
    public GameObject Key;
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        if(other == Key.GetComponent<BoxCollider>())
        {
            Destroy(Door);
        }
    }
}
