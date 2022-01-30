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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireCannon", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FireCannon()
    {
        initvel = transform.forward * 10;
        GameObject cannonBall = Instantiate(cannonBallPrefab, fireloc.position, Quaternion.identity);
        Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.AddForce(initvel, ForceMode.Impulse);
    }
}
