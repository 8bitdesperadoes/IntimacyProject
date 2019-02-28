using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePick : MonoBehaviour {

    public KeyCode keyLeft;
    public KeyCode keyRight;
    public float rotateSpeed = 1;

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = transform.parent.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(keyLeft))
        {
            //transform.Rotate(-rotateSpeed, 0, 0);
            rb.AddTorque(0, 0, rotateSpeed);
        }
        if (Input.GetKey(keyRight))
        {
            //transform.Rotate(rotateSpeed, 0, 0);
            rb.AddTorque(0, 0, -rotateSpeed);
        }
	}

    
}
