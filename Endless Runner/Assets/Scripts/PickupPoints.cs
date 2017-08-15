using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : MonoBehaviour {

	public int scoreToGive;

	private AudioSource coinSound;

	private ScoreManager theScoreManager;

	void Start () {

		theScoreManager = FindObjectOfType<ScoreManager> ();
		coinSound = GameObject.Find ("CoinPickupSound").GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.name == "Player") {

			theScoreManager.AddScore (scoreToGive);
			gameObject.SetActive (false);

			if (coinSound.isPlaying) {
				coinSound.Stop ();
				coinSound.Play ();
			}
			else{
				coinSound.Play ();
			}
		}
	}
}
