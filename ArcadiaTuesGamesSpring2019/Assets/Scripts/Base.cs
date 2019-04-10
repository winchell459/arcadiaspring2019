using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {
    public GameObject Prefab;
    public float RespawnRate = 1f;

    private float lastSpawn = 0;
	// Use this for initialization
	void Start () {
        lastSpawn = Time.fixedTime;
	}
	
	// Update is called once per frame
	void Update () {
        if(lastSpawn + RespawnRate < Time.fixedTime){
            GameObject spawn = Instantiate(Prefab, transform.position, Quaternion.identity);
            spawn.SetActive(true);
            lastSpawn = Time.fixedTime;
        }
	}
}
