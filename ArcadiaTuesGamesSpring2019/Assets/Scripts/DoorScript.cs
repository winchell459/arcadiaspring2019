﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Player"){
            GameObject.FindGameObjectWithTag("DoorController").GetComponent<DoorController>().SelectDoor(this);
        }
	}

    public void OpenDoor(){
        GetComponent<Animator>().SetTrigger("OpenDoor");
    }
}