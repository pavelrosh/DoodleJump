﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_platform : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		//Debug.Log ("BAD");
		Destroy (this.gameObject);
	}
}