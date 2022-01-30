using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    bool player = false;
    public GameObject otherplayer;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            player = !player;
            if(player == false)
            {
                otherplayer.GetComponent<PlayerController>().enabled = false;
                this.GetComponent<PlayerController>().enabled = true;

                otherplayer.GetComponent<PlayerGrab>().enabled = false;
                this.GetComponent<PlayerGrab>().enabled = true;

                otherplayer.GetComponent<Camera>().enabled = false;
                this.GetComponent<Camera>().enabled = true;
            }
            if (player == true)
            {
                otherplayer.GetComponent<PlayerController>().enabled = true;
                this.GetComponent<PlayerController>().enabled = false;

                otherplayer.GetComponent<PlayerGrab>().enabled = true;
                this.GetComponent<PlayerGrab>().enabled = false;

                otherplayer.GetComponent<Camera>().enabled = true;
                this.GetComponent<Camera>().enabled = false;
            }
        }
    }
}
