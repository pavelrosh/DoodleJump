using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	void Update () 
	{
		//Debug.Log (target.position.y);
		if (target.position.y > transform.position.y) {
			Vector3 newPos = new Vector3 (transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		} 
		else if (target.position.y == 0) 
		{
		//	Debug.Log ("DEATH");
			Vector3 newPos = new Vector3 (transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}