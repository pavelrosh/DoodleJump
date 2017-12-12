using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_platform : MonoBehaviour {

	public float jumpForce = 10f;

	IEnumerator Pause_pl()
	{
		
		jumpForce = 0f;
		yield return new WaitForSeconds (1f);
		jumpForce = 10f;
		Debug.Log("4004");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 velocity = rb.velocity;
			StartCoroutine(Pause_pl ());
			velocity.y = jumpForce;
			rb.velocity = velocity;
		}
	}
}
