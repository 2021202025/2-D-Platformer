﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;

	public bool shouldDouble;

	void Start () {
		if (PlayerPrefs.HasKey("HighScore")) {
			hiScoreCount = PlayerPrefs.GetFloat ("HighScore");
		}
	}
	
	void Update () {

		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;
		}

		if (scoreCount > hiScoreCount) {
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", hiScoreCount);
		}

		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		hiScoreText.text = "HighScore: " + Mathf.Round (hiScoreCount);

	}

	public void AddScore (int pointsToAdd) {

		if (shouldDouble) {
			pointsToAdd = pointsToAdd * 2;
		}
		scoreCount += pointsToAdd;

	}
}
