using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform[] Waypoints;
    public float Speed = 10f;

    private int waypointIndex = 0;
    private float buffer = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Vector3.Distance(Waypoints[waypointIndex].position, transform.position) < buffer){
            waypointIndex = (waypointIndex + 1) % Waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[waypointIndex].position,
                                                 Speed * Time.deltaTime);
	}

	public void OnCollisionEnter(Collision collision)
	{
        if(collision.transform.tag == "Player"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
	}
}
