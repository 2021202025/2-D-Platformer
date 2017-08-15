﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

	public float speed = 0.5f;

	void Start () {
		
	}
	
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	}
}
