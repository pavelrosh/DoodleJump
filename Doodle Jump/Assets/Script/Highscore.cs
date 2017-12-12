using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour 
{
	public Text highscore;
	public Transform target;
	float points = 0f;

	void Start()
	{
		highscore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
	}

	void Update()
	{
	//	position_tmp = target.position.y;
		if (points < target.position.y)
		{
			points = target.position.y;
		}
		//text.text = Mathf.FloorToInt(points).ToString();
		if (Mathf.FloorToInt(points) > PlayerPrefs.GetInt("Highscore", 0))
		{
			PlayerPrefs.SetInt("Highscore", Mathf.FloorToInt(points));
			highscore.text = "Highscore: " + Mathf.FloorToInt(points).ToString();
		}
	}
}
