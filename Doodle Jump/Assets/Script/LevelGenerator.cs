using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject platformPrefab;
	public GameObject power_platform;
	public GameObject bad_platform;

	public int numberOfPlatforms = 150;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 1.5f;

	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			if (i > 11 && i % 15 == 0)
				Instantiate(power_platform, spawnPosition, Quaternion.identity);
			else if (i > 21 && i % 10 == 0)
				Instantiate(bad_platform, spawnPosition, Quaternion.identity);
			else
				Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
		}
	}
}
