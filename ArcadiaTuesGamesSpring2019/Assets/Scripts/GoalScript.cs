using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

	

	public void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Player"){
            Debug.Log("GOAL!!!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneManager.
        }
	}
}
