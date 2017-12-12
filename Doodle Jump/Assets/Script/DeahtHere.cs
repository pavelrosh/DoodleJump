using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeahtHere : MonoBehaviour 
{
	public Transform target;

	void Update()
	{
		//Debug.Log ("ZONE");
		Vector3 newPos = new Vector3 (transform.position.x, target.position.y - 4, transform.position.z);
		transform.position = newPos;
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		Player doodle = collider.GetComponent<Player>();
		LevelController.current.HerroDeath (doodle);
	}
}
