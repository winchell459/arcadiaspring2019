using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Franks2_0Player : MonoBehaviour {
    private Rigidbody2D rb;
    public float Speed = 100;
    public float JumpForce = 100;

    private bool grounded = false;
    private float lastVertical = 0;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float move = 0;
        bool jump = Input.GetKeyDown(KeyCode.W);

        if(Input.GetKey(KeyCode.D)){
            move = 1;
        }else if(Input.GetKey(KeyCode.A)){
            move = -1;
        }

        //rb.velocity = Speed * new Vector2(move, 0);
        rb.AddForce(new Vector2(Speed * move, 0));

        if (grounded && jump) rb.AddForce(new Vector2(0, JumpForce));
	}


    public void SetGrounded(bool state){
        grounded = state;
    }
}
