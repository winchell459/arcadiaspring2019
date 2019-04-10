using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	private void OnTriggerStay2D(Collider2D collision)
	{
        if (collision.tag == "Ground") transform.parent.SendMessage("SetGrounded", true);
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
        if(collision.tag == "Ground") transform.parent.SendMessage("SetGrounded", false);
	}
}
