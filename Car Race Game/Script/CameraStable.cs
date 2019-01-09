﻿using UnityEngine;
using System.Collections;

public class CameraStable : MonoBehaviour {

	public GameObject TheCar;
	public float CarX;
	public float CarY;
	public float CarZ;
	
	// Update is called once per frame
	void Update () {
		CarX = TheCar.transform.eulerAngles.x;
		CarY = TheCar.transform.eulerAngles.y;
		CarZ = TheCar.transform.eulerAngles.z;
		
		transform.eulerAngles = new Vector3(CarX-CarX, CarY, CarZ-CarZ);
	}
}
