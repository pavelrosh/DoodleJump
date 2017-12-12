using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour 
{
	public Transform target;
	float points = 0f;
	Text text;

	void Awake()
	{
		text = GetComponent<Text>();
	}
	
	void Update()
	{
	//	position_tmp = target.position.y;
		if (points < target.position.y)
		{
			points = target.position.y;
		}
		text.text = Mathf.FloorToInt(points).ToString();
	}
}