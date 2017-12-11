using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour 
{
	public static LevelController current = null;
	Vector3 startingPosition;

	void Awake()
	{
		current = this;
	}

	public void setStartPosition(Vector3 pos)
	{
		this.startingPosition = pos;
	}

	public void HerroDeath(Player doodle)
	{
		//Debug.Log("lololo");
		doodle.transform.position = this.startingPosition;
	}
}
