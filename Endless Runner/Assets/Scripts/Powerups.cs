using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour {

	public bool doublePoints;
	public bool safeMode;

	public float powerupLength;

	private PowerupManager thePowerupManager;

	public Sprite[] powerupSprites;

	void Start () {
		thePowerupManager = FindObjectOfType<PowerupManager>();
	}


	void Awake() {

		int powerupSelector = Random.Range (0, 4);

		switch (powerupSelector) {
		case 0:
			doublePoints = true;
			break;

		case 1:
			safeMode = true;
			break;

		case 2:
			doublePoints = true;
			break;

		case 3:
			doublePoints = true;
			safeMode = true;
			break;
		}

		GetComponent<SpriteRenderer> ().sprite = powerupSprites [powerupSelector]; 

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			thePowerupManager.ActivatePowerup (doublePoints, safeMode, powerupLength);
		}

		gameObject.SetActive (false);
	}
}
