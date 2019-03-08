using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("a")) {
            Debug.Log("a key pressed");
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("d")) {
            Debug.Log("d key pressed");
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
