using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody rb;
    public float Speed = 1000f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(hMove * Speed * Time.deltaTime, 0, vMove * Speed * Time.deltaTime));
	}
}
