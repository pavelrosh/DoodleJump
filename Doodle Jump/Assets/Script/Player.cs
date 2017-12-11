using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour 
{
	public float movementSpeed = 10f;
	public static Player last_position = null;
	Rigidbody2D rb;
	SpriteRenderer sr = null;
	float movement = 0f;
	float flip_x = 0f;

	void Awake()
	{
		last_position = this;
	}
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		LevelController.current.setStartPosition (transform.position);
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		flip_x = Input.GetAxis ("Horizontal");
		if (flip_x > 0)
			sr.flipX = false;
		else if (flip_x < 0)
			sr.flipX = true;
		
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
