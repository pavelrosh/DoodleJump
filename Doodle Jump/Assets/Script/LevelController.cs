using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour 
{
	public static LevelController current = null;
	Vector3 startingPosition;
	int lifes = 3;
	float points = 0f;

	public Text text;
	public Transform target;
	public Text point;

	void Awake()
	{
		current = this;
	}

	void Update()
	{
		text.text = "LIFES: " + lifes.ToString();
		if (points < target.position.y)
		{
			points = target.position.y;
		}
		point.text = "Score: " + Mathf.FloorToInt(points).ToString();
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(2);
	}

	public void setStartPosition(Vector3 pos)
	{
		this.startingPosition = pos;
	}

	public void HerroDeath(Player doodle)
	{
		lifes--;
		points = 0f;
		if (lifes == 0)
		{
			PlayGame();
		}
		doodle.transform.position = this.startingPosition;
	}
}