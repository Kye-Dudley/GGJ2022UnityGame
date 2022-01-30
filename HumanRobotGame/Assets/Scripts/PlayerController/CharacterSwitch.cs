using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public GameObject otherplayer;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            otherplayer.GetComponent<PlayerController>().enabled = true;
            this.GetComponent<PlayerController>().enabled = false;

            otherplayer.GetComponent<PlayerGrab>().enabled = true;
            this.GetComponent<PlayerGrab>().enabled = false;

            otherplayer.GetComponent<Camera>().enabled = true;
            this.GetComponent<Camera>().enabled = false;
        }
        if (Input.GetKey(KeyCode.R))
        {
            otherplayer.GetComponent<PlayerController>().enabled = false;
            this.GetComponent<PlayerController>().enabled = true;

            otherplayer.GetComponent<PlayerGrab>().enabled = false;
            this.GetComponent<PlayerGrab>().enabled = true;

            otherplayer.GetComponent<Camera>().enabled = false;
            this.GetComponent<Camera>().enabled = true;
        }
    }
}
