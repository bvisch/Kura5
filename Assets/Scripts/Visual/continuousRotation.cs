﻿using UnityEngine;
using System.Collections;

public class continuousRotation : MonoBehaviour {

	public float rotationSpeed = 10.0f;

	void Update()
	{
		transform.Rotate(0, rotationSpeed*Time.deltaTime, 0);
	}
}
